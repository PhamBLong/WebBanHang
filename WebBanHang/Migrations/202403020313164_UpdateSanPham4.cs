namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSanPham4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Sanpham", "maloaisp", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Sanpham", "maloaisp");
        }
    }
}
