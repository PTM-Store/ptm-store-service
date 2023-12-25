using ptm_store_service.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ptm_store_service.Models.Request
{
    public class GalleriesRequestModel
    {
        public string Img { get; set; }

        public string Thumbs { get; set; }

    }
}
