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
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Icon { get; set; }

        [Required]
        [StringLength(50)]
        public string Link { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
