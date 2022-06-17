namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class demo3loi : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.KhachHang", "tuoi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.KhachHang", "tuoi", c => c.Int(nullable: false));
        }
    }
}
