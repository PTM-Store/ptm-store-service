using ptm_store_service.Data;
using ptm_store_service.Repositories.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ptm_store_service.Repositories
{
    public class TagsRepository : ITagsRepository
    {
        private readonly MyDbContext _context;

        public TagsRepository(MyDbContext context)
        {
            _context = context;
        }

        public void CreateTag(Tags tag)
        {
            _context.Tags.Add(tag);
            _context.SaveChanges();
        }

        public List<Tags> GetAllTagsByProductId(int productId)
        {
            var tags = _context.Products
                .Where(p => p.Id == productId)
                .SelectMany(p => p.Tags)
                .ToList();

            return tags;
        }
    }
}
