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
        private readonly IProductsService _productsService;

        public CartLinesService(ICartLinesRepository repository, IProductsService productsService)
        {
            _repository = repository;
            _productsService = productsService;
        }

        public CartLinesResponseModel CreateCartLine(CartLinesAddingRequest cartLinesRequest)
        {
            try
            {
                var cartLines = new CartLines
                {
                    Quantity = 1,
                    CartId = cartLinesRequest.CartId,
                    ProductsId = cartLinesRequest.ProductId
                };
                _repository.CreateCartLine(cartLines);
                var cartLinesResponse = new CartLinesResponseModel
                {
                    Id = cartLines.Id,
                    Quantity = 1,
                    CartId = (int)cartLines.CartId,
                    Product = _productsService.GetProductById((int)cartLines.ProductsId)
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
                    Product = _productsService.GetProductById((int)cartLine.ProductsId)
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
                    Product = _productsService.GetProductById((int)x.ProductsId)
                });
                return cartLinesResponse.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public CartLinesResponseModel UpdateCartLine(int cartLineId, QuantityCartLine quantityCartLine)
        {
            try
            {
                var cartLine = _repository.GetCartLinesById(cartLineId);
                if (cartLine != null)
                {
                    cartLine.Quantity = quantityCartLine.quantity;
                    _repository.UpdateCartLine(cartLine);
                    var cartLinesResponse = new CartLinesResponseModel
                    {
                        Id = cartLine.Id,
                        Quantity = cartLine.Quantity,
                        CartId = (int)cartLine.CartId,
                        Product = _productsService.GetProductById((int)cartLine.ProductsId)
                    };
                    return cartLinesResponse;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
