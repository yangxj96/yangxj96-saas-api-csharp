using System.Reflection;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Nacos.AspNetCore.V2;
using yangxj96_serve_example.Configuration.JsonConverter;
using yangxj96_serve_example.Configuration.JsonNamingPolicy;
using yangxj96_serve_example.Filter;

namespace yangxj96_serve_example;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services
            .AddControllers(options =>
            {
                // 全局异常处理器
                options.Filters.Add(new HttpExceptionFilter());
            })
            .AddJsonOptions(options =>
            {
                var jso = options.JsonSerializerOptions;
                jso.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
                jso.WriteIndented = true;
                jso.Converters.Add(new DateTimeJsonConverter("yyyy-MM-dd HH:mm:ss"));
                jso.PropertyNamingPolicy = new JsonSnakeCaseNamingPolicy();
                jso.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                jso.IgnoreReadOnlyFields = true;
                jso.AllowTrailingCommas = true;
                jso.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });
        // Swagger
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        // nacos配置
        builder.Services.AddNacosAspNet(builder.Configuration, section: "NacosConfig");
        // Autofac
        builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
        builder.Host.ConfigureContainer<ContainerBuilder>(container =>
        {
            var assemblies = Assembly.GetExecutingAssembly();
            // 加载service
            container.RegisterAssemblyTypes(assemblies)
                .Where(type => type.Name.EndsWith("Service"))
                .PublicOnly()
                .Where(type => type.IsClass)
                .AsImplementedInterfaces();
            // 加载远程调用接口
            container.RegisterAssemblyTypes(assemblies)
                .Where(type => type.Name.EndsWith("Remote"))
                .PublicOnly()
                .Where(type => type.IsClass)
                .AsImplementedInterfaces();
        });

        var app = builder.Build();

        // 配置HTTP请求管道。
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();

            app.UseSwagger();
            app.UseSwaggerUI();
        }


        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}