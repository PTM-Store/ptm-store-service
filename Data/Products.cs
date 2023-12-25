using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ptm_store_service.Data
{
    [Table("Product")]
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string SKU { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public int ReviewCounts { get; set; }

        public int Stars { get; set; }

        public string Title { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int OldPrice { get; set; }

        public string Symbols { get; set; }

        [Required]
        public string MainImg { get; set; }

        public virtual ICollection<Galleries> Galleries { get; set; }

        public virtual ICollection<Categories> Categories { get; set; } 

        public virtual ICollection<Reviews> Reviews { get; set; }

        public virtual ICollection<CartLines> CartLines { get; set;}

        public virtual ICollection<Tags> Tags { get; set; }
    }
}
