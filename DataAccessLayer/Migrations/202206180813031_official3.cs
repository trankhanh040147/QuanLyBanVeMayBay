namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class official3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.KhachHang", "CMND", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.NhanVien", "TenDangNhap", c => c.String(nullable: false, maxLength: 50, unicode: false));
            CreateIndex("dbo.KhachHang", "CMND", unique: true);
            CreateIndex("dbo.NhanVien", "TenDangNhap", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.NhanVien", new[] { "TenDangNhap" });
            DropIndex("dbo.KhachHang", new[] { "CMND" });
            AlterColumn("dbo.NhanVien", "TenDangNhap", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.KhachHang", "CMND", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
