using Microsoft.EntityFrameworkCore;
using ptm_store_service.Data;
using ptm_store_service.Repositories.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ptm_store_service.Repositories
{
    public class CartLinesReposotory : ICartLinesRepository
    {
        private readonly MyDbContext _context;

        public CartLinesReposotory(MyDbContext context)
        {
            _context = context;
        }

        public void CreateCartLine(CartLines cartLine)
        {
            _context.CartLines.Add(cartLine);
            _context.SaveChanges();
        }

        public void DeleteCartLine(CartLines cartLine)
        {
            _context.CartLines.Remove(cartLine);
            _context.SaveChanges();
        }

        public List<CartLines> GetAllCartLines()
        {
            var CartLinesList = _context.CartLines.ToList();
            return CartLinesList;
        }

        public CartLines GetCartLinesById(int id)
        {
            var CartLines = _context.CartLines.Find(id);
            return CartLines;
        }

        public void UpdateCartLine(CartLines cartLine)
        {
            _context.Update(cartLine);
            _context.SaveChanges();
        }
    }
}
