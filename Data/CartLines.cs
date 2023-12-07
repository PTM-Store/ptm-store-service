using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ptm_store_service.Data
{
    [Table("CartLines")]
    public class CartLines
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int Quantity { get; set; }

        public int? CartId { get; set; }
        [ForeignKey("CartId")]
        public Carts Cart { get; set; }

        [Required]
        public int? VariantId { get; set; }
        [ForeignKey("VariantId")]
        public Variants Variants { get; set; }
    }
}
