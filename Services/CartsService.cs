using ptm_store_service.Data;
using ptm_store_service.Models.Request;
using ptm_store_service.Models.Response;
using ptm_store_service.Repositories.Interface;
using ptm_store_service.Services.Interface;

namespace ptm_store_service.Services
{
    public class CartsService : ICartsService
    {
        private readonly ICartsRepository _cartsRepository;

        public CartsService(ICartsRepository cartsRepository)
        {
            _cartsRepository = cartsRepository;
        }

        public CartsResponseModel CreateCart(CartsRequestModel cartsRequestModel)
        {
            var cart = new Carts
            {
                UserId = cartsRequestModel.UserId
            };

            _cartsRepository.CreateCart(cart);
            var cartResponse = new CartsResponseModel
            {
                Id = cart.Id,
                UserId = cart.UserId
            };
            return cartResponse;
        }

        public CartsResponseModel GetCartByUserId(int userId)
        {
            var cart = _cartsRepository.GetCartByUserId(userId);
            var cartResponse = new CartsResponseModel
            {
                Id = cart.Id,
                UserId = cart.UserId
            };
            return cartResponse;
        }
    }
}
