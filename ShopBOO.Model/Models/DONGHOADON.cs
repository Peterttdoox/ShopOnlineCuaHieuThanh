namespace ShopBOO.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONGHOADON")]
    public partial class DONGHOADON
    {
        [Key]
        public int MADONGHOADON { get; set; }

        public int ID_MAHOADON { get; set; }

        public int ID_MASANPHAM { get; set; }

        public int? SOLUONG { get; set; }

        public int? THANHTIEN { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
