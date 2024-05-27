namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData9 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tb_HinhanhSPs", "SanPham_id", "dbo.tb_Sanpham");
            DropIndex("dbo.tb_HinhanhSPs", new[] { "SanPham_id" });
            DropColumn("dbo.tb_HinhanhSPs", "ProductID");
            RenameColumn(table: "dbo.tb_HinhanhSPs", name: "SanPham_id", newName: "ProductID");
            AlterColumn("dbo.tb_HinhanhSPs", "ProductID", c => c.Int(nullable: false));
            CreateIndex("dbo.tb_HinhanhSPs", "ProductID");
            AddForeignKey("dbo.tb_HinhanhSPs", "ProductID", "dbo.tb_Sanpham", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_HinhanhSPs", "ProductID", "dbo.tb_Sanpham");
            DropIndex("dbo.tb_HinhanhSPs", new[] { "ProductID" });
            AlterColumn("dbo.tb_HinhanhSPs", "ProductID", c => c.Int());
            RenameColumn(table: "dbo.tb_HinhanhSPs", name: "ProductID", newName: "SanPham_id");
            AddColumn("dbo.tb_HinhanhSPs", "ProductID", c => c.Int(nullable: false));
            CreateIndex("dbo.tb_HinhanhSPs", "SanPham_id");
            AddForeignKey("dbo.tb_HinhanhSPs", "SanPham_id", "dbo.tb_Sanpham", "id");
        }
    }
}
