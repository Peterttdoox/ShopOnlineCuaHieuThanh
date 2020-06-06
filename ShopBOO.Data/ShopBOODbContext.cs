using ShopBOO.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBOO.Data
{
    public class ShopBOODbContext : DbContext
    {
        public ShopBOODbContext() : base("ShopBOOConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<BANGPHANQUYEN> BANGPHANQUYENs { get; set; }
        public DbSet<CUAHANG> CUAHANGs { get; set; }
        public DbSet<DONGCUAHANG> DONGCUAHANGs { get; set; }
        public DbSet<DONGHOADON> DONGHOADONs { get; set; }
        public DbSet<HINH_ANH> HINH_ANHs { get; set; }
        public DbSet<HOADON> HOADONs { get; set; }
        public DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public DbSet<MAUSAC> MAUSACs { get; set; }
        public DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public DbSet<NHANVIEN> NHANVIENs { get; set; }
        public DbSet<NHAPKHO> NHAPKHOs { get; set; }
        public DbSet<NHOMMAUSAC> NHOMMAUSACs { get; set; }
        public DbSet<NHOMSANPHAM> NHOMSANPHAMs { get; set; }
        public DbSet<SANPHAM> SANPHAMs { get; set; }
        public DbSet<SIZE> SIZEs { get; set; }
        public DbSet<XUATKHO> XUATKHOs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
