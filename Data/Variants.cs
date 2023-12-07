using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ptm_store_service.Data
{
    [Table("Variants")]
    public class Variants
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public string SkuCode { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public double Price { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Sale price must be greater than 0")]
        public double SalePrice { get; set; }

        public string Image { get; set; }

        public virtual CartLines CartLines { get; set; }

        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Products Products { get; set; }
    }
}
