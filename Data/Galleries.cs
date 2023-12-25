using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ptm_store_service.Data
{
    [Table("Galleries")]
    public class Galleries
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Img { get; set; }

        public string Thumbs { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
