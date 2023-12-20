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
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public ProductsResponseModel CreateProduct(ProductsRequestModel productsRequest)
        {
            try
            {
                var product = new Products
                {
                    Title = productsRequest.Title,
                    Description = productsRequest.Description,
                    Image = productsRequest.Image,
                    Status = productsRequest.Status,
                    CategoryId = productsRequest.CategoryId
                };
                _productsRepository.CreateProduct(product);
                var productResponse = new ProductsResponseModel
                {
                    Id = product.Id,
                    Title = product.Title,
                    Description = product.Description,
                    Image = product.Image,
                    Status = product.Status,
                    CategoryId = product.CategoryId
                };
                return productResponse;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteProduct(int id)
        {
            try
            {
                var product = _productsRepository.GetProductsById(id);
                _productsRepository.DeleteProduct(product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProductsResponseModel> GetAllProducts()
        {
            try
            {
                var products = _productsRepository.GetAllProducts();
                var productsResponseList = products.Select(pr => new ProductsResponseModel
                {
                    Id = pr.Id,
                    Title = pr.Title,
                    Description = pr.Description,
                    Image = pr.Image,
                    Status = pr.Status,
                    CategoryId = pr.CategoryId
                });
                return productsResponseList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProductsResponseModel> GetProductsByCategoryId(int categoryId)
        {
            try
            {
                var products = _productsRepository.GetProductsByCategoryId(categoryId);
                var productsResponse = products.Select(pr => new ProductsResponseModel
                {
                    Id = pr.Id,
                    Title = pr.Title,
                    Description = pr.Description,
                    Image = pr.Image,
                    Status = pr.Status,
                    CategoryId = pr.CategoryId
                });
                return productsResponse.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public ProductsResponseModel GetProductsById(int id)
        {
            try
            {
                var product = _productsRepository.GetProductsById(id);
                var productResponse = new ProductsResponseModel
                {
                Id = product.Id,
                Title = product.Title,
                Description = product.Description,
                Image = product.Image,
                Status = product.Status,
                CategoryId = product.CategoryId
                };
                return productResponse;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Products UpdateProduct(ProductsResponseModel productsResponse)
        {
            try
            {
                var product = _productsRepository.GetProductsById(productsResponse.Id);
                product.Title = productsResponse.Title;
                product.Description = productsResponse.Description;
                product.Image = productsResponse.Image;
                product.Status = productsResponse.Status;
                product.CategoryId = productsResponse.CategoryId;
                return product;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
