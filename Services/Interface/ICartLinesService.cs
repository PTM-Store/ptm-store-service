using ptm_store_service.Data;
using ptm_store_service.Models.Request;
using ptm_store_service.Models.Response;
using System.Collections.Generic;

namespace ptm_store_service.Services.Interface
{
    public interface ICartLinesService
    {
        CartLinesResponseModel GetCartLine(int id);
        CartLinesResponseModel CreateCartLine(CartLinesAddingRequest cartLinesRequest);
        CartLinesResponseModel UpdateCartLine(int cartLineId, QuantityCartLine quantityCartLine);
        void DeleteCartLine(int id);
        List<CartLinesResponseModel> GetCartLinesByCartId(int cartId);
    }
}
