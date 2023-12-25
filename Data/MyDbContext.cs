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
        public DbSet<Token> Tokens { get; set; }
        public DbSet<Galleries> Galleries { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Tags> Tags { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
            });

            modelBuilder.Entity<Categories>()
            .HasMany(c => c.Products)
            .WithMany(p => p.Categories)
            .UsingEntity(j => j.ToTable("Products_Categories"));

            modelBuilder.Entity<Products>()
            .HasMany(p => p.Galleries)
            .WithMany(g => g.Products)
            .UsingEntity(j => j.ToTable("Products_Galleries"));

            modelBuilder.Entity<Products>()
            .HasMany(p => p.Tags)
            .WithMany(t => t.Products)
            .UsingEntity(j => j.ToTable("Products_Tags"));
        }
    }
}
