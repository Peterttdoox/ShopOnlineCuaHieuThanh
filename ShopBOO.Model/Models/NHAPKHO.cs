namespace ShopBOO.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHAPKHO")]
    public partial class NHAPKHO
    {
        [Key]
        public int MANHAP { get; set; }

        [StringLength(100)]
        public string TENHANG { get; set; }

        public int ID_MASANPHAM { get; set; }

        public int ID_MANHACUNGCAP { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYNHAP { get; set; }

        public int? SOLUONG { get; set; }

        [Column(TypeName = "money")]
        public decimal? TONGTIEN { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
