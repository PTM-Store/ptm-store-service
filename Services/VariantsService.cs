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
    public class VariantsService : IVariantsService
    {
        private readonly IVariantsRepository _variantsRepository;

        public VariantsService(IVariantsRepository variantsRepository)
        {
            _variantsRepository = variantsRepository;
        }

        public Variants CreateVariant(VariantsRequestModel variantsRequest)
        {
            try
            {
                var variant = new Variants
                {
                    Name = variantsRequest.Name,
                    SkuCode = variantsRequest.SkuCode,
                    Price = variantsRequest.Price,
                    SalePrice = variantsRequest.SalePrice,
                    Image = variantsRequest.Image,
                    ProductId = variantsRequest.ProductId
                };
                _variantsRepository.CreateVariant(variant);
                return variant;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteVariant(int id)
        {
            try
            {
                var variant = _variantsRepository.GetVariantsById(id);
                _variantsRepository.DeleteVariant(variant);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<VariantsResponseModel> GetAllVariants()
        {
            try
            {
                var variantsList = _variantsRepository.GetAllVariants();
                var variantsResponseList = variantsList.Select(va => new VariantsResponseModel
                {
                    Id = va.Id,
                    Name = va.Name,
                    SkuCode = va.SkuCode,
                    Price = va.Price,
                    SalePrice = va.SalePrice,
                    Image = va.Image,
                    ProductId = va.ProductId
                });
                return variantsResponseList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public VariantsResponseModel GetVariantById(int id)
        {
            try
            {
                var variant = _variantsRepository.GetVariantsById(id);
                var variantResponse = new VariantsResponseModel
                {
                    Id = variant.Id,
                    Name = variant.Name,
                    SkuCode = variant.SkuCode,
                    Price = variant.Price,
                    SalePrice = variant.SalePrice,
                    Image = variant.Image,
                    ProductId = variant.ProductId
                };
                return variantResponse;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Variants UpdateVariant(VariantsResponseModel variantsResponse)
        {
            try
            {
                var variant = _variantsRepository.GetVariantsById(variantsResponse.Id);
                if (variant != null)
                {
                    variant.Id = variantsResponse.Id;
                    variant.Name = variantsResponse.Name;
                    variant.SkuCode = variantsResponse.SkuCode;
                    variant.Price = variantsResponse.Price;
                    variant.SalePrice = variantsResponse.SalePrice;
                    variant.Image = variantsResponse.Image;
                    variant.ProductId = variantsResponse.ProductId;
                    _variantsRepository.UpdateVariant(variant);
                    return variant;
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
