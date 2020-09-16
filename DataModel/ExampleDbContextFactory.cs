using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DataModel
{
    public class ExampleDbContextFactory : IDesignTimeDbContextFactory<ExampleDbContext>
    {
        public ExampleDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ExampleDbContext> builder = new DbContextOptionsBuilder<ExampleDbContext>();

            var accessor = new HttpContextAccessor { HttpContext = new DefaultHttpContext() };

            return new ExampleDbContext(builder.Options, accessor);
        }
    }
}