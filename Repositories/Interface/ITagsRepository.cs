using ptm_store_service.Data;
using System.Collections.Generic;

namespace ptm_store_service.Repositories.Interface
{
    public interface ITagsRepository
    {
        void CreateTag(Tags tag);
        List<Tags> GetAllTagsByProductId(int productId);
    }
}
