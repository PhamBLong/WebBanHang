namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData7 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.HinhanhSPs", newName: "tb_HinhanhSPs");
            DropIndex("dbo.tb_Sanpham", new[] { "LoaiSps_id" });
            AddColumn("dbo.tb_HinhanhSPs", "ProductID", c => c.Int(nullable: false));
            AddColumn("dbo.tb_HinhanhSPs", "Image", c => c.String());
            AddColumn("dbo.tb_LoaiSP", "Title", c => c.String(nullable: false, maxLength: 150));
            CreateIndex("dbo.tb_Sanpham", "LoaiSps_ID");
            DropColumn("dbo.tb_HinhanhSPs", "id_sanpham");
            DropColumn("dbo.tb_HinhanhSPs", "hinhanh");
            DropColumn("dbo.tb_LoaiSP", "ten");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_LoaiSP", "ten", c => c.String(nullable: false, maxLength: 150));
            AddColumn("dbo.tb_HinhanhSPs", "hinhanh", c => c.String());
            AddColumn("dbo.tb_HinhanhSPs", "id_sanpham", c => c.Int(nullable: false));
            DropIndex("dbo.tb_Sanpham", new[] { "LoaiSps_ID" });
            DropColumn("dbo.tb_LoaiSP", "Title");
            DropColumn("dbo.tb_HinhanhSPs", "Image");
            DropColumn("dbo.tb_HinhanhSPs", "ProductID");
            CreateIndex("dbo.tb_Sanpham", "LoaiSps_id");
            RenameTable(name: "dbo.tb_HinhanhSPs", newName: "HinhanhSPs");
        }
    }
}
