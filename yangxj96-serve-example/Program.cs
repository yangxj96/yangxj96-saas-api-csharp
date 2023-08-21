using System.Reflection;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Nacos.AspNetCore.V2;
using yangxj96_serve_example.Configuration.JsonConverter;
using yangxj96_serve_example.Configuration.JsonNamingPolicy;

namespace yangxj96_serve_example;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services
            .AddControllers()
            // System.Text.Json ����
            .AddJsonOptions(options =>
            {
                var jso = options.JsonSerializerOptions;
                // �����ʽ
                jso.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
                // �Ƿ��ʽ���ı�
                jso.WriteIndented = true;
                // ���ʱ���ʽת����
                jso.Converters.Add(new DateTimeJsonConverter("yyyy-MM-dd HH:mm:ss"));
                // �ֶ�ʹ���»���
                jso.PropertyNamingPolicy = new JsonSnakeCaseNamingPolicy();
                // ����nullֵ
                jso.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                // ����ֻ���ֶ�
                jso.IgnoreReadOnlyFields = true;
                // ��������ֵĩβ���ڶ���
                jso.AllowTrailingCommas = true;
                // ����ѭ����������
                jso.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });
        // Swagger
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        // ���nacos����
        builder.Services.AddNacosAspNet(builder.Configuration, section: "NacosConfig");
        // ��ط���ע��
        // builder.Services.AddSingleton<SystemRemote>();
        builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

        builder.Host.ConfigureContainer<ContainerBuilder>(container =>
        {
            var assemblies = Assembly.GetExecutingAssembly();
            // serviceע��
            container.RegisterAssemblyTypes(assemblies) //���������о����� 
                .Where(type => type.Name.EndsWith("Service"))
                .PublicOnly() //ֻҪpublic����Ȩ�޵�
                .Where(type => type.IsClass) //ֻҪclass�ͣ���ҪΪ���ų�ֵ��interface���ͣ� 
                .AsImplementedInterfaces();
            // Զ�̵��õ�ע��
            container.RegisterAssemblyTypes(assemblies) //���������о����� 
                .Where(type => type.Name.EndsWith("Remote"))
                .PublicOnly() //ֻҪpublic����Ȩ�޵�
                .Where(type => type.IsClass) //ֻҪclass�ͣ���ҪΪ���ų�ֵ��interface���ͣ� 
                .AsImplementedInterfaces();
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            // ������Ա����ҳ��
            app.UseDeveloperExceptionPage();

            app.UseSwagger();
            app.UseSwaggerUI();
        }


        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}