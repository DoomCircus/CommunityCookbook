namespace CommunityCookbook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ingredient
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int ingredientID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ingredientName { get; set; }

        [StringLength(250)]
        public string ingredientDescription { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool optional { get; set; }
    }
}
