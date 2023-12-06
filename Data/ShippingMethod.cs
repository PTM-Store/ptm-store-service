using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ptm_store_service.Data
{
    [Table("ShippingMethod")]
    public class ShippingMethod
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShippingMethodID { get; set; }

        [MaxLength(255)]
        [Required(ErrorMessage = "Shipping Method Name is required.")]
        public string ShippingMethodName { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        [Range(0, double.MaxValue, ErrorMessage = "giá không hợp lệ.")]
        public decimal Price { get; set; }


    }
}
