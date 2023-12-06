using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ptm_store_service.Data
{
    [Table("Categories")]
    public class Categories
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(255)] 
        public string CategoryName { get; set; }

        [Required]
        [RegularExpression(@"^[a-z0-9-]+$", ErrorMessage = "Slug không hợp lệ.")]
        public string CategorySlug { get; set; }

        public int? ParentId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

        [Required]
        [MaxLength(255)] 
        public string Tag { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
