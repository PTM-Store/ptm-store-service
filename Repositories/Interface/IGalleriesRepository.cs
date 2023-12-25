using ptm_store_service.Data;
using System.Collections.Generic;

namespace ptm_store_service.Repositories.Interface
{
    public interface IGalleriesRepository
    {
        void CreateGallery (Galleries gallery);
        List<Galleries> GetAllGalleriesByProductId (int productId);
    }
}
