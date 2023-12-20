using ptm_store_service.Data;
using ptm_store_service.Repositories.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ptm_store_service.Repositories
{
    public class VariantsRepository : IVariantsRepository
    {
        private readonly MyDbContext _context;

        public VariantsRepository(MyDbContext context)
        {
            _context = context;
        }

        public void CreateVariant(Variants variant)
        {
            _context.Variants.Add(variant);
            _context.SaveChanges();
        }

        public void DeleteVariant(Variants variant)
        {
            _context.Variants.Remove(variant);
            _context.SaveChanges();
        }

        public List<Variants> GetAllVariants()
        {
            var VariantsList = _context.Variants.ToList();
            return VariantsList;
        }

        public Variants GetVariantsById(int id)
        {
            var Variants = _context.Variants.Find(id);
            return Variants;
        }

        public List<Variants> GetVariantsByProductId(int id)
        {
            var ListVariants = _context.Variants.Where(va =>  va.ProductId == id).ToList();
            return ListVariants;
        }

        public void UpdateVariant(Variants variant)
        {
            _context.Variants.Update(variant);
            _context.SaveChanges();
        }
    }
}
