using ptm_store_service.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ptm_store_service.Models.Response
{
    public class GalleriesResponseModel
    {
        public int Id { get; set; }
        public string Img { get; set; }

        public string Thumbs { get; set; }
    }
}
