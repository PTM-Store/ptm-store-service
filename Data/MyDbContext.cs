using Microsoft.EntityFrameworkCore;


namespace ptm_store_service.Data
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        #region DBSet
        public DbSet<Users> Users { get; set; }
        public DbSet<Addresses> Addresss { get; set; }
        public DbSet<Carts> Carts { get; set; }
        public DbSet<CartLines> CartLines { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Variants> Variants { get; set; }
        public DbSet<Token> Tokens { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
            });
        }
    }
}
