using ptm_store_service.Data;
using ptm_store_service.Models.Request;
using ptm_store_service.Models.Response;

namespace ptm_store_service.Services.Interface
{
    public interface ICartsService
    {
        CartsResponseModel CreateCart(CartsRequestModel cartsRequestModel);
        CartsResponseModel GetCartByUserId(int userId);
    }
}
