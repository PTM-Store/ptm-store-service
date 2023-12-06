using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ptm_store_service.Data
{
    [Table("Addresses")]
    public class Addresses
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }


        [Required]
        public string Street { get; set; }

        [Required]
        public string Ward { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Province { get; set; }

        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public Users User { get; set; }
    }
}
