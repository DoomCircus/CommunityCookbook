namespace CommunityCookbook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RecipeCategory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int categoryID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string category { get; set; }
    }
}
