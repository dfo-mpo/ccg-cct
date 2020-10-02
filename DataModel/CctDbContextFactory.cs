using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DataModel
{
    public class CctDbContextFactory : IDesignTimeDbContextFactory<CctDbContext>
    {
        public CctDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<CctDbContext> builder = new DbContextOptionsBuilder<CctDbContext>();
            var accessor = new HttpContextAccessor { HttpContext = new DefaultHttpContext() };
            return new CctDbContext(builder.Options, accessor);
        }
    }
}