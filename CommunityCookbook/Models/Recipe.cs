namespace CommunityCookbook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Recipe
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int recipeID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int posterID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string recipeName { get; set; }

        [StringLength(1000)]
        public string recipeDescription { get; set; }

        public int? categoryID { get; set; }
    }
}
