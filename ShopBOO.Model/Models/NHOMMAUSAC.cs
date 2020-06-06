namespace ShopBOO.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHOMMAUSAC")]
    public partial class NHOMMAUSAC
    {
        [Key]
        public int MANHOMMAUSAC { get; set; }

        [StringLength(100)]
        public string TENNHOMMAUSAC { get; set; }
    }
}
