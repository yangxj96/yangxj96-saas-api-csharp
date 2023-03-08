using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Nacos.AspNetCore.V2;
using yangxj96_serve_example.Configuration.JsonConverter;
using yangxj96_serve_example.Configuration.JsonNamingPolicy;
using yangxj96_serve_example.Remote;
using yangxj96_serve_example.Repository;
using yangxj96_serve_example.Repository.Impl;

namespace yangxj96_serve_example
{
    public class Program
    {
        protected Program()
        {
        }

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
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // ���nacos����
            builder.Services.AddNacosAspNet(builder.Configuration, section: "NacosConfig");
            // EF 
            builder.Services.AddDbContextPool<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServer"));
            });
            // ��ط���ע��
            builder.Services.AddSingleton<SystemRemote>();

            // ���ݿ����ע��
            builder.Services.AddSingleton<AppDbContext>();
            builder.Services.AddSingleton<IDemoRepository, DemoRepositoryImpl>();

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
}