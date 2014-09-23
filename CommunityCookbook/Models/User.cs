namespace CommunityCookbook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int userID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string username { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string password { get; set; }

        [StringLength(50)]
        public string firstName { get; set; }

        [StringLength(50)]
        public string lastName { get; set; }
    }
}
