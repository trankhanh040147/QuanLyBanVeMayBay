using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Code first
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;


namespace DataAccessLayer
{
    public partial class QuanLyVeMayBayContext : DbContext
    {
        public QuanLyVeMayBayContext()
            : base("name=QLVMBConnectionString")
        {
        }

        public virtual DbSet<ChuyenBay> ChuyenBays { get; set; }
        public virtual DbSet<DuongBay> DuongBays { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<MayBay> MayBays { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<ThongBao> ThongBaos { get; set; }
        public virtual DbSet<ThongTinChiTietVe> ThongTinChiTietVes { get; set; }
        public virtual DbSet<VeBan> VeBans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChuyenBay>()
                .Property(e => e.MaChuyenBay)
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenBay>()
                .Property(e => e.MaDuongBay)
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenBay>()
                .Property(e => e.MaMayBay)
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenBay>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenBay>()
                .Property(e => e.DiemDen)
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenBay>()
                .Property(e => e.DiemDi)
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenBay>()
                .HasMany(e => e.ThongTinChiTietVes)
                .WithRequired(e => e.ChuyenBay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DuongBay>()
                .Property(e => e.MaDuongBay)
                .IsUnicode(false);

            modelBuilder.Entity<DuongBay>()
                .Property(e => e.ViTri)
                .IsUnicode(false);

            modelBuilder.Entity<DuongBay>()
                .Property(e => e.TinhTrang)
                .IsUnicode(false);

            modelBuilder.Entity<DuongBay>()
                .HasMany(e => e.ChuyenBays)
                .WithRequired(e => e.DuongBay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.MaHangHoa)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.MaVeBan)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.Loai)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.TenHangHoa)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.HoKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.TenKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.TenLotKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.DiaChi)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.VeBans)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MayBay>()
                .Property(e => e.MaMayBay)
                .IsUnicode(false);

            modelBuilder.Entity<MayBay>()
                .Property(e => e.TenMayBay)
                .IsUnicode(false);

            modelBuilder.Entity<MayBay>()
                .Property(e => e.HangSanXuat)
                .IsUnicode(false);

            modelBuilder.Entity<MayBay>()
                .HasMany(e => e.ChuyenBays)
                .WithRequired(e => e.MayBay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.TenNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.HoNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.TenLotNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.DiaChi)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.ChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.ThongBaos)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.VeBans)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThongBao>()
                .Property(e => e.MaThongBao)
                .IsUnicode(false);

            modelBuilder.Entity<ThongBao>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<ThongBao>()
                .Property(e => e.ThongBao1)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinChiTietVe>()
                .Property(e => e.MaVe)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinChiTietVe>()
                .Property(e => e.MaChuyenBay)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinChiTietVe>()
                .Property(e => e.LoaiVe)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinChiTietVe>()
                .HasMany(e => e.VeBans)
                .WithRequired(e => e.ThongTinChiTietVe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VeBan>()
                .Property(e => e.MaVe)
                .IsUnicode(false);

            modelBuilder.Entity<VeBan>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<VeBan>()
                .Property(e => e.MaKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<VeBan>()
                .Property(e => e.MaVeBan)
                .IsUnicode(false);

            modelBuilder.Entity<VeBan>()
                .HasMany(e => e.HangHoas)
                .WithRequired(e => e.VeBan)
                .WillCascadeOnDelete(false);
        }
    }
}
