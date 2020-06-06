namespace ShopBOO.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONGCUAHANG")]
    public partial class DONGCUAHANG
    {
        [Key]
        public int MADONGCUAHANG { get; set; }

        public int ID_MACUAHANG { get; set; }

        public int ID_MANHANVIEN { get; set; }

        public virtual CUAHANG CUAHANG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
