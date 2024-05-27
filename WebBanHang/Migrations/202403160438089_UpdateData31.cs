namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData31 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_DonHang", "TotalAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.tb_DonHang", "soluong", c => c.Int(nullable: false));
            DropColumn("dbo.tb_DonHang", "ghichu");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_DonHang", "ghichu", c => c.String());
            AlterColumn("dbo.tb_DonHang", "soluong", c => c.String());
            DropColumn("dbo.tb_DonHang", "TotalAmount");
        }
    }
}
