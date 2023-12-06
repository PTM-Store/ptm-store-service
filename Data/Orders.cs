using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ptm_store_service.Data
{
    [Table("Orders")]
    public class Orders
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [Required] public int UserID { get; set; }
        [Required] public int AddressId { get; set; }
        [Required] public string PhoneId { get; set; }

        [MaxLength(255)]
        public string Note { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "số lượng không hợp lệ.")]
        public decimal Quantity { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Tổng đơn không hợp lệ.")]
        public decimal Total { get; set; }

        [Required] 
        public DateTime OrderDate { get; set; }

        [Required] public int PaymentMethodId { get; set; }
        [Required] public int ShippingMethodId { get; set; }
    }
}
