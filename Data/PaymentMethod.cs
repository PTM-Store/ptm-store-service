using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ptm_store_service.Data
{
    [Table("PaymentMethod")]
    public class PaymentMethod
    {
        [Key]
        public int PaymentMethodId { get; set; }

        [Required]
        [StringLength(16)]
        [RegularExpression(@"^\d{16}$", ErrorMessage = "Invalid card number")]
        public string CardNumber { get; set;}

        [Required]
        [StringLength(255)]
        public string NameOnCard { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }
    }
}
