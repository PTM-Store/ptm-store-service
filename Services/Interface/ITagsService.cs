using ptm_store_service.Models.Request;
using ptm_store_service.Models.Response;
using System.Collections.Generic;

namespace ptm_store_service.Services.Interface
{
    public interface ITagsService
    {
        TagsResponseModel CreateTag(TagsRequestModel tagsRequestModel);
        List<TagsResponseModel> GetAllTagsByProductId(int productId);
    }
}
