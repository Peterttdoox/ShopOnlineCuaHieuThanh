namespace ShopBOO.Model.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Web_Ban_Quan_Ao : DbContext
    {
        public Web_Ban_Quan_Ao()
            : base("name=Web_Ban_Quan_Ao")
        {
        }

        public virtual DbSet<BANGPHANQUYEN> BANGPHANQUYENs { get; set; }
        public virtual DbSet<CUAHANG> CUAHANGs { get; set; }
        public virtual DbSet<DONGCUAHANG> DONGCUAHANGs { get; set; }
        public virtual DbSet<DONGHOADON> DONGHOADONs { get; set; }
        public virtual DbSet<HINH_ANH> HINH_ANH { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<MAUSAC> MAUSACs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<NHAPKHO> NHAPKHOes { get; set; }
        public virtual DbSet<NHOMMAUSAC> NHOMMAUSACs { get; set; }
        public virtual DbSet<NHOMSANPHAM> NHOMSANPHAMs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<SIZE> SIZEs { get; set; }
        public virtual DbSet<XUATKHO> XUATKHOes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CUAHANG>()
                .HasMany(e => e.DONGCUAHANGs)
                .WithRequired(e => e.CUAHANG)
                .HasForeignKey(e => e.ID_MACUAHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CUAHANG>()
                .HasMany(e => e.SANPHAMs)
                .WithRequired(e => e.CUAHANG)
                .HasForeignKey(e => e.ID_MACUAHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HINH_ANH>()
                .HasMany(e => e.SANPHAMs)
                .WithRequired(e => e.HINH_ANH)
                .HasForeignKey(e => e.ID_MAHINHANH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.DONGHOADONs)
                .WithRequired(e => e.HOADON)
                .HasForeignKey(e => e.ID_MAHOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.KHACHHANG)
                .HasForeignKey(e => e.ID_MAKHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAUSAC>()
                .HasMany(e => e.SANPHAMs)
                .WithRequired(e => e.MAUSAC)
                .HasForeignKey(e => e.ID_MAMAU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .HasMany(e => e.NHAPKHOes)
                .WithRequired(e => e.NHACUNGCAP)
                .HasForeignKey(e => e.ID_MANHACUNGCAP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.BANGPHANQUYENs)
                .WithRequired(e => e.NHANVIEN)
                .HasForeignKey(e => e.ID_MANHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.DONGCUAHANGs)
                .WithRequired(e => e.NHANVIEN)
                .HasForeignKey(e => e.ID_MANHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.NHANVIEN)
                .HasForeignKey(e => e.ID_MANHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHAPKHO>()
                .Property(e => e.TONGTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NHOMSANPHAM>()
                .HasMany(e => e.SANPHAMs)
                .WithRequired(e => e.NHOMSANPHAM)
                .HasForeignKey(e => e.ID_MANHOM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.DONGIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.DONGHOADONs)
                .WithRequired(e => e.SANPHAM)
                .HasForeignKey(e => e.ID_MASANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.NHAPKHOes)
                .WithRequired(e => e.SANPHAM)
                .HasForeignKey(e => e.ID_MASANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.XUATKHOes)
                .WithRequired(e => e.SANPHAM)
                .HasForeignKey(e => e.ID_MASANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SIZE>()
                .HasMany(e => e.SANPHAMs)
                .WithRequired(e => e.SIZE)
                .HasForeignKey(e => e.ID_MASIZE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<XUATKHO>()
                .Property(e => e.TONGTIEN)
                .HasPrecision(19, 4);
        }
    }
}
