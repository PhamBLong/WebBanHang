namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Menu", "isActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_Tintuc", "chitiet", c => c.String());
            AddColumn("dbo.tb_Tintuc", "isActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_Sanpham", "masanpham", c => c.String());
            AddColumn("dbo.tb_Sanpham", "maloaisp", c => c.String());
            AddColumn("dbo.tb_Sanpham", "isHot", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_Sanpham", "isActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_QuangCao", "isActive", c => c.Boolean(nullable: false));
            DropColumn("dbo.tb_Sanpham", "madonhang");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Sanpham", "madonhang", c => c.String());
            DropColumn("dbo.tb_QuangCao", "isActive");
            DropColumn("dbo.tb_Sanpham", "isActive");
            DropColumn("dbo.tb_Sanpham", "isHot");
            DropColumn("dbo.tb_Sanpham", "maloaisp");
            DropColumn("dbo.tb_Sanpham", "masanpham");
            DropColumn("dbo.tb_Tintuc", "isActive");
            DropColumn("dbo.tb_Tintuc", "chitiet");
            DropColumn("dbo.tb_Menu", "isActive");
        }
    }
}
