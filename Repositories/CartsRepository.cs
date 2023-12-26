using ptm_store_service.Data;
using ptm_store_service.Repositories.Interface;
using System.Linq;

namespace ptm_store_service.Repositories
{
    public class CartsRepository : ICartsRepository
    {
        private readonly MyDbContext _context;

        public CartsRepository(MyDbContext context)
        {
            _context = context;
        }

        public void CreateCart(Carts cart)
        {
            _context.Carts.Add(cart);
            _context.SaveChanges();
        }

        public Carts GetCartByUserId(int userId)
        {
            var cart = _context.Carts.FirstOrDefault(c => c.UserId == userId);
            return cart;
        }
    }
}
