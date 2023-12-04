using Microsoft.EntityFrameworkCore;

namespace ptm_store_service.Data
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        #region DBSet
        public DbSet<Users> Users { get; set; }
        public DbSet<Addresses> Addresss { get; set; }
        #endregion
    }
}
