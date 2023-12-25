using ptm_store_service.Data;
using ptm_store_service.Models.Request;
using ptm_store_service.Models.Response;
using ptm_store_service.Repositories.Interface;
using ptm_store_service.Services.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ptm_store_service.Services
{
    public class TagsService : ITagsService
    {
        private readonly ITagsRepository _tagsRepository;

        public TagsService(ITagsRepository tagsRepository)
        {
            _tagsRepository = tagsRepository;
        }

        public TagsResponseModel CreateTag(TagsRequestModel tagsRequestModel)
        {
            var tag = new Tags
            {
                Name = tagsRequestModel.Name,
                Link = tagsRequestModel.Link,
            };
            _tagsRepository.CreateTag(tag);
            var tagResponse = new TagsResponseModel
            {
                Id = tag.Id,
                Name = tag.Name,
                Link = tag.Link,
            };
            return tagResponse;
        }

        public List<TagsResponseModel> GetAllTagsByProductId(int productId)
        {
            var tags = _tagsRepository.GetAllTagsByProductId(productId);
            var tagsResponse = tags.Select(ta => new TagsResponseModel
            {
                Id = ta.Id,
                Name = ta.Name,
                Link = ta.Link
            }).ToList();
            return tagsResponse;
        }
    }
}
