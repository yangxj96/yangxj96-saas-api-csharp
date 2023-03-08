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
                // System.Text.Json 配置
                .AddJsonOptions(options =>
                {
                    var jso = options.JsonSerializerOptions;
                    // 编码格式
                    jso.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
                    // 是否格式化文本
                    jso.WriteIndented = true;
                    // 添加时间格式转换器
                    jso.Converters.Add(new DateTimeJsonConverter("yyyy-MM-dd HH:mm:ss"));
                    // 字段使用下划线
                    jso.PropertyNamingPolicy = new JsonSnakeCaseNamingPolicy();
                    // 忽略null值
                    jso.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                    // 忽略只读字段
                    jso.IgnoreReadOnlyFields = true;
                    // 允许属性值末尾存在逗号
                    jso.AllowTrailingCommas = true;
                    // 处理循环引用类型
                    jso.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // 添加nacos服务
            builder.Services.AddNacosAspNet(builder.Configuration, section: "NacosConfig");
            // EF 
            builder.Services.AddDbContextPool<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServer"));
            });
            // 相关服务注入
            builder.Services.AddSingleton<SystemRemote>();

            // 数据库相关注入
            builder.Services.AddSingleton<AppDbContext>();
            builder.Services.AddSingleton<IDemoRepository, DemoRepositoryImpl>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                // 开发人员详情页面
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