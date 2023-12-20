using ptm_store_service.Data;
using ptm_store_service.Models.Request;
using ptm_store_service.Models.Response;
using System.Collections.Generic;

namespace ptm_store_service.Services.Interface
{
    public interface IVariantsService
    {
        List<VariantsResponseModel> GetAllVariants();
        VariantsResponseModel GetVariantById(int id);
        Variants CreateVariant(VariantsRequestModel variantsRequest);
        Variants UpdateVariant(VariantsResponseModel variantsResponse);
        void DeleteVariant(int id);
        List<VariantsResponseModel> GetVariantsByProductId(int productId);
    }
}
