using System;
using Microsoft.EntityFrameworkCore;
using TestSupport.EfHelpers;

namespace DataModel.Tests
{
    public class DbHelper<T> where T : DbContext
    {
        private readonly DbContextOptions<T> _options;
        private readonly TestHttpContextAccessor _testHttpContextAccessor;

        public DbHelper()
        {
            _options = SqliteInMemory.CreateOptions<T>();
            _testHttpContextAccessor = new TestHttpContextAccessor();
        }

        public DbHelper(DbContextOptions<T> options)
        {
            _options = options;
        }

        public T GetDbContext()
        {
            return (T) Activator.CreateInstance(typeof(T), _options, _testHttpContextAccessor);
        }

        public DbHelper<T> RunMigrations()
        {
            using (var db = GetDbContext())
            {
                db.Database.EnsureCreated();
            }

            return this;
        }

    }
}
