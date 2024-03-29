using System.Reflection;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Nacos.AspNetCore.V2;
using Yangxj96.Serve.Common.Configuration.JsonConverter;
using Yangxj96.Serve.Common.Configuration.JsonNamingPolicy;
using Yangxj96.Serve.Example.Filter;

namespace Yangxj96.Serve.Example;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services
            .AddScoped<UniformResponseExtraHelper>()
            .AddControllers(options =>
            {
                // 全局异常处理器
                options.Filters.Add(new HttpExceptionFilter());
                // 全局响应修改过滤器处理器
                options.Filters.Add<UniformResponseFilter>();
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

        // 配置HTTP请求管道。如果是开发模式,则启用swagger
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