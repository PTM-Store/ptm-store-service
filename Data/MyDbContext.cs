using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace ptm_store_service.Data
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        #region DBSet
        public DbSet<Categories> categories { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<Addresses> addresses { get; set; }
        public DbSet<CartLines> cartLines { get; set; }
        public DbSet<Carts> carts { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<Orders> orders { get; set; }
        public DbSet<PaymentMethod> paymentMethods { get; set; }
        public DbSet<Phones> phones { get; set; }
        public DbSet<ShippingMethod> shippingMethods { get; set; }
        public DbSet<Task> tasks { get; set; }

        internal Task<IEnumerable<object>> FindAsync(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
