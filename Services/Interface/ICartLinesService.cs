using ptm_store_service.Data;
using ptm_store_service.Models.Request;
using ptm_store_service.Models.Response;
using System.Collections.Generic;

namespace ptm_store_service.Services.Interface
{
    public interface ICartLinesService
    {
        List<CartLinesResponseModel> GetAllCartLines();
        CartLinesResponseModel GetCartLine(int id);
        CartLines CreateCartLine(CartLinesRequestModel cartLinesRequest);
        CartLines UpdateCartLine(CartLinesRequestModel cartLinesRequest);
        void DeleteCartLine(int id);
        List<CartLinesResponseModel> GetCartLinesByCartId(int cartId);
    }
}
