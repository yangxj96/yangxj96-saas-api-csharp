using Nacos.AspNetCore.V2;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using yangxj96_serve_demo.Configuration.JsonConverter;
using yangxj96_serve_demo.Configuration.JsonNamingPolicy;

namespace yangxj96_serve_demo
{
    public class Program
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
                    // ����ʱ���ʽת����
                    jso.Converters.Add(new DateTimeJsonConverter("yyyy-MM-dd HH:mm:ss"));
                    // �ֶ�ʹ���շ�����
                    // jso.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
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
                })
                ;
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // ����nacos����
            builder.Services.AddNacosAspNet(builder.Configuration, section: "NacosConfig");

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}