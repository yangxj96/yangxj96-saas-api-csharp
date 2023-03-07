using Microsoft.EntityFrameworkCore;
using yangxj96_serve_example.Model;

namespace yangxj96_serve_example.Extensions
{
    public static class ModelBuilderExtensions
    {
        /// <summary>
        /// 扩展ModelBuilder
        /// </summary>
        /// <param name="modelBuilder">ModelBuilder</param>
        public static void SeedDemo(this ModelBuilder modelBuilder)
        {
            List<Demo> demos = new();
            for (var i = 1; i < 100; i++)
            {
                var datum = new Demo()
                {
                    Id = i,
                    Name = $"Name{i}",
                    Description = $"Description{i}",
                    CreatedDate = DateTime.Now
                };
                demos.Add(datum);
            }
            modelBuilder.Entity<Demo>().HasData(demos);
        }
    }
}
