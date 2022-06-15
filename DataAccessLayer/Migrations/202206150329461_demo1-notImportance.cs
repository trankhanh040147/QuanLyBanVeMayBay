namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class demo1notImportance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChuyenBay",
                c => new
                    {
                        MaChuyenBay = c.String(nullable: false, maxLength: 10, unicode: false),
                        MaDuongBay = c.String(nullable: false, maxLength: 10, unicode: false),
                        MaMayBay = c.String(nullable: false, maxLength: 10, unicode: false),
                        NgayDen = c.DateTime(nullable: false, storeType: "date"),
                        GhiChu = c.String(maxLength: 50, unicode: false),
                        NgayDi = c.DateTime(nullable: false, storeType: "date"),
                        GioBay = c.Time(nullable: false, precision: 7),
                        DiemDen = c.String(nullable: false, maxLength: 50, unicode: false),
                        DiemDi = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.MaChuyenBay)
                .ForeignKey("dbo.DuongBay", t => t.MaDuongBay)
                .ForeignKey("dbo.MayBay", t => t.MaMayBay)
                .Index(t => t.MaDuongBay)
                .Index(t => t.MaMayBay);
            
            CreateTable(
                "dbo.DuongBay",
                c => new
                    {
                        MaDuongBay = c.String(nullable: false, maxLength: 10, unicode: false),
                        ViTri = c.String(nullable: false, maxLength: 50, unicode: false),
                        ChieuDai = c.Double(nullable: false),
                        ChieuRong = c.Double(nullable: false),
                        TinhTrang = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.MaDuongBay);
            
            CreateTable(
                "dbo.MayBay",
                c => new
                    {
                        MaMayBay = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenMayBay = c.String(nullable: false, maxLength: 50, unicode: false),
                        HangSanXuat = c.String(maxLength: 50, unicode: false),
                        KichThuoc = c.Int(nullable: false),
                        SoGheL1 = c.Int(nullable: false),
                        SoGheL2 = c.Int(nullable: false),
                        Tong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaMayBay);
            
            CreateTable(
                "dbo.ThongTinChiTietVe",
                c => new
                    {
                        MaVe = c.String(nullable: false, maxLength: 10, unicode: false),
                        MaChuyenBay = c.String(nullable: false, maxLength: 10, unicode: false),
                        LoaiVe = c.String(nullable: false, maxLength: 30, unicode: false),
                        SoLuong = c.Int(nullable: false),
                        SoLuongCon = c.Int(nullable: false),
                        Gia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaVe)
                .ForeignKey("dbo.ChuyenBay", t => t.MaChuyenBay)
                .Index(t => t.MaChuyenBay);
            
            CreateTable(
                "dbo.VeBan",
                c => new
                    {
                        MaVeBan = c.String(nullable: false, maxLength: 10, unicode: false),
                        MaVe = c.String(nullable: false, maxLength: 10, unicode: false),
                        SLVeBan = c.Int(nullable: false),
                        MaNhanVien = c.String(nullable: false, maxLength: 10, unicode: false),
                        MaKhachHang = c.String(nullable: false, maxLength: 10, unicode: false),
                        TongTien = c.Int(nullable: false),
                        ThoiGianBan = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ThoiGianThanhToan = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        SoLuongHangHoa = c.Int(),
                    })
                .PrimaryKey(t => t.MaVeBan)
                .ForeignKey("dbo.KhachHang", t => t.MaKhachHang)
                .ForeignKey("dbo.NhanVien", t => t.MaNhanVien)
                .ForeignKey("dbo.ThongTinChiTietVe", t => t.MaVe)
                .Index(t => t.MaVe)
                .Index(t => t.MaNhanVien)
                .Index(t => t.MaKhachHang);
            
            CreateTable(
                "dbo.HangHoa",
                c => new
                    {
                        MaHangHoa = c.String(nullable: false, maxLength: 10, unicode: false),
                        MaVeBan = c.String(nullable: false, maxLength: 10, unicode: false),
                        TrongLuong = c.Double(nullable: false),
                        Loai = c.String(nullable: false, maxLength: 60, unicode: false),
                        TenHangHoa = c.String(nullable: false, maxLength: 60, unicode: false),
                    })
                .PrimaryKey(t => t.MaHangHoa)
                .ForeignKey("dbo.VeBan", t => t.MaVeBan)
                .Index(t => t.MaVeBan);
            
            CreateTable(
                "dbo.KhachHang",
                c => new
                    {
                        MaKhachHang = c.String(nullable: false, maxLength: 10, unicode: false),
                        HoKhachHang = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenKhachHang = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenLotKhachHang = c.String(maxLength: 50, unicode: false),
                        SoDienThoai = c.String(nullable: false, maxLength: 10, unicode: false),
                        DiaChi = c.String(nullable: false, maxLength: 50, unicode: false),
                        CMND = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.MaKhachHang);
            
            CreateTable(
                "dbo.NhanVien",
                c => new
                    {
                        MaNhanVien = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenNhanVien = c.String(nullable: false, maxLength: 10, unicode: false),
                        HoNhanVien = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenLotNhanVien = c.String(maxLength: 50, unicode: false),
                        DiaChi = c.String(nullable: false, maxLength: 11, unicode: false),
                        SoDienThoai = c.String(nullable: false, maxLength: 50, unicode: false),
                        ChucVu = c.String(maxLength: 50, unicode: false),
                        TenDangNhap = c.String(nullable: false, maxLength: 50, unicode: false),
                        MatKhau = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.MaNhanVien);
            
            CreateTable(
                "dbo.ThongBao",
                c => new
                    {
                        MaThongBao = c.String(nullable: false, maxLength: 10, unicode: false),
                        MaNhanVien = c.String(nullable: false, maxLength: 10, unicode: false),
                        ThongBao = c.String(nullable: false, maxLength: 500, unicode: false),
                        ThoiGian = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        KiemTraChu = c.Int(nullable: false),
                        KiemTraTram = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaThongBao)
                .ForeignKey("dbo.NhanVien", t => t.MaNhanVien)
                .Index(t => t.MaNhanVien);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ThongTinChiTietVe", "MaChuyenBay", "dbo.ChuyenBay");
            DropForeignKey("dbo.VeBan", "MaVe", "dbo.ThongTinChiTietVe");
            DropForeignKey("dbo.VeBan", "MaNhanVien", "dbo.NhanVien");
            DropForeignKey("dbo.ThongBao", "MaNhanVien", "dbo.NhanVien");
            DropForeignKey("dbo.VeBan", "MaKhachHang", "dbo.KhachHang");
            DropForeignKey("dbo.HangHoa", "MaVeBan", "dbo.VeBan");
            DropForeignKey("dbo.ChuyenBay", "MaMayBay", "dbo.MayBay");
            DropForeignKey("dbo.ChuyenBay", "MaDuongBay", "dbo.DuongBay");
            DropIndex("dbo.ThongBao", new[] { "MaNhanVien" });
            DropIndex("dbo.HangHoa", new[] { "MaVeBan" });
            DropIndex("dbo.VeBan", new[] { "MaKhachHang" });
            DropIndex("dbo.VeBan", new[] { "MaNhanVien" });
            DropIndex("dbo.VeBan", new[] { "MaVe" });
            DropIndex("dbo.ThongTinChiTietVe", new[] { "MaChuyenBay" });
            DropIndex("dbo.ChuyenBay", new[] { "MaMayBay" });
            DropIndex("dbo.ChuyenBay", new[] { "MaDuongBay" });
            DropTable("dbo.ThongBao");
            DropTable("dbo.NhanVien");
            DropTable("dbo.KhachHang");
            DropTable("dbo.HangHoa");
            DropTable("dbo.VeBan");
            DropTable("dbo.ThongTinChiTietVe");
            DropTable("dbo.MayBay");
            DropTable("dbo.DuongBay");
            DropTable("dbo.ChuyenBay");
        }
    }
}
