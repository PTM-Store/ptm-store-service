using ptm_store_service.Data;
using ptm_store_service.Repositories.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ptm_store_service.Repositories
{
    public class GalleriesRepository : IGalleriesRepository
    {
        private readonly MyDbContext _context;

        public GalleriesRepository(MyDbContext context)
        {
            _context = context;
        }

        public void CreateGallery(Galleries gallery)
        {
            _context.Galleries.Add(gallery);
            _context.SaveChanges();
        }

        public List<Galleries> GetAllGalleriesByProductId(int productId)
        {
            var galleries = _context.Products
                .Where(p => p.Id == productId)
                .SelectMany(p => p.Galleries)
                .ToList();

            return galleries;
        }
    }
}
