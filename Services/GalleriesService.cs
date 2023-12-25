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
    public class GalleriesService : IGalleriesService
    {
        private readonly IGalleriesRepository _galleriesRepository;

        public GalleriesService(IGalleriesRepository galleriesRepository)
        {
            _galleriesRepository = galleriesRepository;
        }

        public GalleriesResponseModel CreateGallery(GalleriesRequestModel request)
        {
            try
            {
                var gallery = new Galleries
                {
                    Img = request.Img,
                    Thumbs = request.Thumbs,
                };
                _galleriesRepository.CreateGallery(gallery);
                var response = new GalleriesResponseModel
                {
                    Id = gallery.Id,
                    Img = gallery.Img,
                    Thumbs = gallery.Thumbs,
                };

                return response;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<GalleriesResponseModel> GetGalleriesByProductId(int productId)
        {
            try
            {
                var galleries = _galleriesRepository.GetAllGalleriesByProductId(productId);
                var galleriesResponse = galleries.Select(ga => new GalleriesResponseModel
                {
                    Id = ga.Id,
                    Img = ga.Img,
                    Thumbs = ga.Thumbs,
                });
                return galleriesResponse.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
