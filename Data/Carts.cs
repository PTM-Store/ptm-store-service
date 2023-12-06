
﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace ptm_store_service.Data
{
    [Table("CartLines")]

    public class Carts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        public int? UserID { get; set; }
        [ForeignKey("UserId")]
        public Users User { get; set; }

        public virtual ICollection<CartLines> CartLines { get; set; }
    }
}
