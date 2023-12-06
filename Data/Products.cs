using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ptm_store_service.Data
{
    [Table("Product")]
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }


        public string Image { get; set;}


        public int Status { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime CreateBy { get; set; }

        
        public int? SupplierID { get; set; }

        public int? CategoryID { get; set; }



    }
}
