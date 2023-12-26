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

        public CartLinesResponseModel CreateCartLine(CartLinesRequestModel cartLinesRequest)
        {
            try
            {
                var cartLines = new CartLines
                {
                    Quantity = cartLinesRequest.Quantity,
                    CartId = cartLinesRequest.CartId,
                    ProductsId = cartLinesRequest.ProductId
                };
                _repository.CreateCartLine(cartLines);
                var cartLinesResponse = new CartLinesResponseModel
                {
                    Id = cartLines.Id,
                    Quantity = cartLines.Quantity,
                    CartId = (int)cartLines.CartId,
                    ProductId = (int)cartLines.ProductsId
                };
                return cartLinesResponse;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteCartLine(int id)
        {
            try
            {
                var cartLine = _repository.GetCartLinesById(id);
                _repository.DeleteCartLine(cartLine);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CartLinesResponseModel GetCartLine(int id)
        {
            try
            {
                var cartLine = _repository.GetCartLinesById(id);
                var cartLinesResponse = new CartLinesResponseModel
                {
                    Id = cartLine.Id,
                    Quantity = cartLine.Quantity,
                    CartId = (int)cartLine.CartId,
                    ProductId = (int)cartLine.ProductsId
                };
                return cartLinesResponse;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<CartLinesResponseModel> GetCartLinesByCartId(int cartId)
        {
            try
            {
                var cartLines = _repository.GetCartLinesByCartId(cartId);
                var cartLinesResponse = cartLines.Select(x => new CartLinesResponseModel
                {
                    Id = x.Id,
                    Quantity = x.Quantity,
                    CartId = (int)x.CartId,
                    ProductId = (int)x.ProductsId
                });
                return cartLinesResponse.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public CartLinesResponseModel UpdateCartLine(CartLinesRequestModel cartLinesRequest)
        {
            try
            {
                var cartLine = _repository.GetCartLinesById(cartLinesRequest.Id);
                if (cartLine != null)
                {
                    cartLine.Quantity = cartLinesRequest.Quantity;
                    cartLine.CartId = cartLinesRequest.CartId;
                    cartLine.ProductsId = cartLinesRequest.ProductId;
                    _repository.UpdateCartLine(cartLine);
                }
                var cartLinesResponse = new CartLinesResponseModel
                {
                    Id = cartLine.Id,
                    Quantity = cartLine.Quantity,
                    CartId = (int)cartLine.CartId,
                    ProductId = (int)cartLine.ProductsId
                };
                return cartLinesResponse;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
