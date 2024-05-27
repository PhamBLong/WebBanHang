namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData41 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_ChitietDonhang", "OrderId", c => c.Int(nullable: false));
            AddColumn("dbo.tb_ChitietDonhang", "ProductId", c => c.Int(nullable: false));
            AddColumn("dbo.tb_ChitietDonhang", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.tb_ChitietDonhang", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.tb_DonHang", "Code", c => c.String(nullable: false));
            AddColumn("dbo.tb_DonHang", "CustomerName", c => c.String(nullable: false));
            AddColumn("dbo.tb_DonHang", "Quantity", c => c.Int(nullable: false));
            DropColumn("dbo.tb_ChitietDonhang", "id_donhang");
            DropColumn("dbo.tb_ChitietDonhang", "id_sanpham");
            DropColumn("dbo.tb_ChitietDonhang", "gia");
            DropColumn("dbo.tb_ChitietDonhang", "tongsoluong");
            DropColumn("dbo.tb_DonHang", "madonhang");
            DropColumn("dbo.tb_DonHang", "tenKhachhang");
            DropColumn("dbo.tb_DonHang", "soluong");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_DonHang", "soluong", c => c.Int(nullable: false));
            AddColumn("dbo.tb_DonHang", "tenKhachhang", c => c.String(nullable: false));
            AddColumn("dbo.tb_DonHang", "madonhang", c => c.String(nullable: false));
            AddColumn("dbo.tb_ChitietDonhang", "tongsoluong", c => c.String());
            AddColumn("dbo.tb_ChitietDonhang", "gia", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.tb_ChitietDonhang", "id_sanpham", c => c.Int(nullable: false));
            AddColumn("dbo.tb_ChitietDonhang", "id_donhang", c => c.Int(nullable: false));
            DropColumn("dbo.tb_DonHang", "Quantity");
            DropColumn("dbo.tb_DonHang", "CustomerName");
            DropColumn("dbo.tb_DonHang", "Code");
            DropColumn("dbo.tb_ChitietDonhang", "Quantity");
            DropColumn("dbo.tb_ChitietDonhang", "Price");
            DropColumn("dbo.tb_ChitietDonhang", "ProductId");
            DropColumn("dbo.tb_ChitietDonhang", "OrderId");
        }
    }
}
