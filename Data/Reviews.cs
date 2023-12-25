using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ptm_store_service.Data
{
    [Table("Reviews")]
    public class Reviews
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Stars { get; set; }

        [Required]
        public string Comment { get; set; }

        public string Picture { get; set; }

        public int? ProductId { get; set; }
        [ForeignKey("ProductsId")]
        public Products Products { get; set; }
    }
}
