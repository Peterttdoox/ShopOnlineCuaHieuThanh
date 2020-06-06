namespace ShopBOO.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            DONGHOADONs = new HashSet<DONGHOADON>();
            NHAPKHOes = new HashSet<NHAPKHO>();
            XUATKHOes = new HashSet<XUATKHO>();
        }

        [Key]
        public int MASANPHAM { get; set; }

        [StringLength(100)]
        public string TENSANPHAM { get; set; }

        public int ID_MACUAHANG { get; set; }

        public int ID_MASIZE { get; set; }

        public int ID_MAMAU { get; set; }

        public int ID_MANHOM { get; set; }

        public int ID_MAHINHANH { get; set; }

        [Column(TypeName = "money")]
        public decimal? DONGIA { get; set; }

        public int? SOLUONG { get; set; }

        [StringLength(1000)]
        public string MOTASANPHAM { get; set; }

        public virtual CUAHANG CUAHANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONGHOADON> DONGHOADONs { get; set; }

        public virtual HINH_ANH HINH_ANH { get; set; }

        public virtual MAUSAC MAUSAC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHAPKHO> NHAPKHOes { get; set; }

        public virtual NHOMSANPHAM NHOMSANPHAM { get; set; }

        public virtual SIZE SIZE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XUATKHO> XUATKHOes { get; set; }
    }
}
