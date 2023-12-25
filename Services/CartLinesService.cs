using ptm_store_service.Data;
using ptm_store_service.Models.Request;
using ptm_store_service.Models.Response;
using ptm_store_service.Repositories.Interface;
using ptm_store_service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ptm_store_service.Services
{
    public class CartLinesService : ICartLinesService
    {
        private readonly ICartLinesRepository _repository;

        public CartLinesService(ICartLinesRepository repository)
        {
            _repository = repository;
        }

        public CartLines CreateCartLine(CartLinesRequestModel cartLinesRequest)
        {
            throw new NotImplementedException();
        }

        public void DeleteCartLine(int id)
        {
            throw new NotImplementedException();
        }

        public List<CartLinesResponseModel> GetAllCartLines()
        {
            throw new NotImplementedException();
        }

        public CartLinesResponseModel GetCartLine(int id)
        {
            throw new NotImplementedException();
        }

        public List<CartLinesResponseModel> GetCartLinesByCartId(int cartId)
        {
            throw new NotImplementedException();
        }

        public CartLines UpdateCartLine(CartLinesRequestModel cartLinesRequest)
        {
            throw new NotImplementedException();
        }
    }
}
