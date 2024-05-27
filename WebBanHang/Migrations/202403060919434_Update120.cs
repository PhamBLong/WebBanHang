namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update120 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Sanpham", "khuyenmai", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Sanpham", "khuyenmai", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
