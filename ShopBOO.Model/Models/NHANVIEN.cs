namespace ShopBOO.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            BANGPHANQUYENs = new HashSet<BANGPHANQUYEN>();
            DONGCUAHANGs = new HashSet<DONGCUAHANG>();
            HOADONs = new HashSet<HOADON>();
        }

        [Key]
        public int MANHANVIEN { get; set; }

        [Required]
        [StringLength(100)]
        public string TENNHANVIEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSINH { get; set; }

        public int? SDT { get; set; }

        [StringLength(1000)]
        public string EMAIL { get; set; }

        public int? SO_CMT { get; set; }

        [StringLength(100)]
        public string TRANGTHAI { get; set; }

        public int MATKHAU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANGPHANQUYEN> BANGPHANQUYENs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONGCUAHANG> DONGCUAHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}
