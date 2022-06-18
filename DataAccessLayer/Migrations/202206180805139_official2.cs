namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class official2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.KhachHang", "CMND", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.KhachHang", "CMND", c => c.String(nullable: false, maxLength: 20, unicode: false));
        }
    }
}
