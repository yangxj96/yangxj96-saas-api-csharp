using Microsoft.EntityFrameworkCore;
using yangxj96_serve_example.Model;

namespace yangxj96_serve_example.Repository.Impl
{
    public class DemoRepositoryImpl : IDemoRepository
    {
        private readonly AppDbContext _context;

        public DemoRepositoryImpl(AppDbContext context)
        {
            _context = context;
        }

        public Demo Add(Demo param)
        {
            _context.Demos.Add(param);
            _context.SaveChanges();
            return param;
        }

        public Demo Update(Demo param)
        {
            _context.Demos.Update(param);
            _context.SaveChanges();
            return param;
        }

        public Demo? Delete(int id)
        {
            var datum = _context.Demos.Find(id);
            if (datum != null)
            {
                _context.Demos.Remove(datum);
                _context.SaveChanges();
            }

            return datum;
        }

        public Demo? GetDemo(int id)
        {
            return _context.Demos.Find(id);
        }

        public IEnumerable<Demo> GetAllDemos()
        {
            return _context.Demos;
        }
    }
}