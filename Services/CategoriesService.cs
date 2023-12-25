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
    public class CategoriesService : ICategoriesService
    {
        private readonly ICategoriesRepository _categoriesRepository;

        public CategoriesService(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }

        public Categories CreateCategory(CategoriesRequestModel categoriesRequest)
        {
            try
            {
                var category = new Categories
                {
                    Name = categoriesRequest.Name,
                    Icon = categoriesRequest.Icon,
                    Link = categoriesRequest.Link,
                };
                _categoriesRepository.CreateCategory(category);
                return category;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteCategory(int id)
        {
            try
            {
                var category = _categoriesRepository.GetCategoryById(id);
                _categoriesRepository.DeleteCategory(category);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CategoriesResponseModel> GetAllCategoriesByProductId(int productId)
        {
            var categories = _categoriesRepository.GetAllCategoriesProductId(productId);
            var categoriesRespones = categories.Select(ca => new CategoriesResponseModel
            {
                Id = ca.Id,
                Name = ca.Name,
                Icon = ca.Icon,
                Link = ca.Link,
            });
            return categoriesRespones.ToList();
        }

        public CategoriesResponseModel GetCategoryById(int id)
        {
            try
            {
                var category = _categoriesRepository.GetCategoryById(id);
                if (category != null)
                {
                    var categoriesResponse = new CategoriesResponseModel
                    {
                        Id = category.Id,
                        Name = category.Name,
                        Icon = category.Icon,
                        Link = category.Link
                    };
                    return categoriesResponse;
                }
                return null;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Categories UpdateCategory(CategoriesResponseModel categoriesResponse)
        {
            try
            {
                var category = _categoriesRepository.GetCategoryById(categoriesResponse.Id);
                if(category != null)
                {
                    category.Name = categoriesResponse.Name;
                    category.Icon = categoriesResponse.Icon;
                    category.Link = categoriesResponse.Link;
                    _categoriesRepository.UpdateCategory(category);
                    return category;
                }
                return null;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
