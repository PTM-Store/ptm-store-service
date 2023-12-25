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

        private readonly ICategoriesService _categoriesService;

        private readonly ITagsService _tagsService;

        private readonly IReviewsService _reviewsService;

        private readonly IGalleriesService _galleryeriesService;

        public ProductsService(IProductsRepository productsRepository, ICategoriesService categoriesService, ITagsService tagsService, IReviewsService reviewsService, IGalleriesService galleryeriesService)
        {
            _productsRepository = productsRepository;
            _categoriesService = categoriesService;
            _tagsService = tagsService;
            _reviewsService = reviewsService;
            _galleryeriesService = galleryeriesService;
        }

        public ProductsResponseModel CreateProduct(ProductsRequestModel request)
        {
            try
            {
                var product = new Products
                {
                    SKU = request.SKU,
                    Content = request.Content,
                    ReviewCounts = request.ReviewCounts,
                    Stars = request.Stars,
                    Title = request.Title,
                    Price = request.Price,
                    OldPrice = request.OldPrice,
                    Symbols = request.Symbols,
                    MainImg = request.MainImg,
                };
                _productsRepository.CreateProduct(product);
                var productResponse = new ProductsResponseModel
                {
                    Id = product.Id,
                    SKU = product.SKU,
                    Content = product.Content,
                    ReviewCounts = product.ReviewCounts,
                    Stars = product.Stars,
                    Title = product.Title,
                    Price = product.Price,
                    OldPrice = product.OldPrice,
                    Symbols = product.Symbols,
                    MainImg = product.MainImg,
                };
                return productResponse;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<ProductsResponseModel> GetAllProducts()
        {
            try
            {
                var productList = _productsRepository.GetAllProducts();
                var products = productList.Select(x => new ProductsResponseModel
                {
                    Id = x.Id,
                    SKU = x.SKU,
                    Content = x.Content,
                    ReviewCounts = x.ReviewCounts,
                    Stars = x.Stars,
                    Price = x.Price,
                    OldPrice = x.OldPrice,
                    Title = x.Title,
                    Symbols = x.Symbols,
                    MainImg = x.MainImg,
                    Categories = _categoriesService.GetAllCategoriesByProductId(x.Id),
                    Tags = _tagsService.GetAllTagsByProductId(x.Id),
                    Reviews = _reviewsService.GetReviewsByProductId(x.Id),
                    Gallery = _galleryeriesService.GetGalleriesByProductId(x.Id),
                });
                return products.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public ProductsResponseModel GetProductById(int id)
        {
            try
            {
                var product = _productsRepository.GetProductsById(id);
                var productResponse = new ProductsResponseModel
                {
                    Id = product.Id,
                    SKU = product.SKU,
                    Content = product.Content,
                    ReviewCounts = product.ReviewCounts,
                    Stars = product.Stars,
                    Price = product.Price,
                    OldPrice = product.OldPrice,
                    Title = product.Title,
                    Symbols = product.Symbols,
                    MainImg = product.MainImg,
                    Categories = _categoriesService.GetAllCategoriesByProductId(id),
                    Tags = _tagsService.GetAllTagsByProductId(id),
                    Reviews = _reviewsService.GetReviewsByProductId(id),
                    Gallery = _galleryeriesService.GetGalleriesByProductId(id)
                };
                return productResponse;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
