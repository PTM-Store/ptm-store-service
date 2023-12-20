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
            try
            {
                var cartLines = new CartLines
                {
                    Quantity = cartLinesRequest.Quantity,
                    CartId = cartLinesRequest.CartId,
                    VariantId = cartLinesRequest.VariantId,
                };
                _repository.CreateCartLine(cartLines);
                return cartLines;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void DeleteCartLine(int id)
        {
            try
            {
                var CartLine = _repository.GetCartLinesById(id);
                _repository.DeleteCartLine(CartLine);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public List<CartLinesResponseModel> GetAllCartLines()
        {
            try
            {
                var cartLinesList = _repository.GetAllCartLines();
                var responseList = cartLinesList.Select(cartLine => new CartLinesResponseModel
                {
                    Id = cartLine.Id,
                    Quantity = cartLine.Quantity,
                    CartId = (int)cartLine.CartId,
                    VariantId = (int)cartLine.VariantId
                });
                return responseList.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public CartLinesResponseModel GetCartLine(int id)
        {
            try
            {
                var cartLine = _repository.GetCartLinesById(id);
                var cartLineResponse = new CartLinesResponseModel
                {
                    Id = cartLine.Id,
                    Quantity = cartLine.Quantity,
                    CartId = (int)cartLine.CartId,
                    VariantId = (int)cartLine.VariantId
                };
                return cartLineResponse;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<CartLinesResponseModel> GetCartLinesByCartId(int cartId)
        {
            var cartLines = _repository.GetCartLinesByCartId(cartId);
            var cartLinesResponse = cartLines.Select(x => new CartLinesResponseModel
            {
                Id = x.Id,
                Quantity = x.Quantity,
                CartId = (int)x.CartId,
                VariantId = (int)x.VariantId

            });
            return cartLinesResponse.ToList();
        }

        public CartLines UpdateCartLine(CartLinesRequestModel cartLinesRequest)
        {
            try
            {
                var cartLines = _repository.GetCartLinesById(cartLinesRequest.Id);
                if(cartLines != null)
                {
                    cartLines.Quantity = cartLinesRequest.Quantity;
                    cartLines.CartId = cartLinesRequest.CartId;
                    cartLines.VariantId = cartLinesRequest.VariantId;
                    _repository.UpdateCartLine(cartLines);
                    return cartLines;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
