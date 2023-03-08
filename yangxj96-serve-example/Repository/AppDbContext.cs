using Microsoft.EntityFrameworkCore;
using yangxj96_serve_example.Extensions;
using yangxj96_serve_example.Model;

namespace yangxj96_serve_example.Repository
{
    /// <summary>
    /// 迁移概述 https://learn.microsoft.com/zh-cn/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
    /// </summary>
    public class AppDbContext : DbContext
    {
        public DbSet<Demo> Demos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// 生成种子数据
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedDemo();
        }
    }
}