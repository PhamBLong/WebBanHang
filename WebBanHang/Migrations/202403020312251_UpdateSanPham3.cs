namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSanPham3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_Sanpham", "maloaisp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Sanpham", "maloaisp", c => c.String());
        }
    }
}
