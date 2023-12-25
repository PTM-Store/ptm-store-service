using ptm_store_service.Models.Request;
using ptm_store_service.Models.Response;
using System.Collections.Generic;

namespace ptm_store_service.Services.Interface
{
    public interface IGalleriesService
    {
        GalleriesResponseModel CreateGallery(GalleriesRequestModel request);
        List<GalleriesResponseModel> GetGalleriesByProductId(int productId);
    }
}
