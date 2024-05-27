namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSanPham : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Sanpham", "khuyenmai", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Sanpham", "khuyenmai");
        }
    }
}
