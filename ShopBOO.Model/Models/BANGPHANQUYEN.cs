namespace ShopBOO.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANGPHANQUYEN")]
    public partial class BANGPHANQUYEN
    {
        [Key]
        public int MAPHANQUYEN { get; set; }

        public int ID_MANHANVIEN { get; set; }

        [StringLength(100)]
        public string CHUCVU { get; set; }

        [StringLength(1000)]
        public string MOTA { get; set; }

        [StringLength(100)]
        public string NGUOITAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYTAO { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
