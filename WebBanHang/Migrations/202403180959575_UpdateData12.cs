namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData12 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tb_ChitietDonhang", "SanPham_id", "dbo.tb_Sanpham");
            DropIndex("dbo.tb_ChitietDonhang", new[] { "SanPham_id" });
            DropColumn("dbo.tb_ChitietDonhang", "ProductId");
            RenameColumn(table: "dbo.tb_ChitietDonhang", name: "SanPham_id", newName: "ProductId");
            AlterColumn("dbo.tb_ChitietDonhang", "ProductId", c => c.Int(nullable: false));
            CreateIndex("dbo.tb_ChitietDonhang", "ProductId");
            AddForeignKey("dbo.tb_ChitietDonhang", "ProductId", "dbo.tb_Sanpham", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_ChitietDonhang", "ProductId", "dbo.tb_Sanpham");
            DropIndex("dbo.tb_ChitietDonhang", new[] { "ProductId" });
            AlterColumn("dbo.tb_ChitietDonhang", "ProductId", c => c.Int());
            RenameColumn(table: "dbo.tb_ChitietDonhang", name: "ProductId", newName: "SanPham_id");
            AddColumn("dbo.tb_ChitietDonhang", "ProductId", c => c.Int(nullable: false));
            CreateIndex("dbo.tb_ChitietDonhang", "SanPham_id");
            AddForeignKey("dbo.tb_ChitietDonhang", "SanPham_id", "dbo.tb_Sanpham", "id");
        }
    }
}
