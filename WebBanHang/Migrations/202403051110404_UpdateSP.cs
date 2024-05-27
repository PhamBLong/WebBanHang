namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSP : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tb_Sanpham", "LoaiSps_id", "dbo.tb_LoaiSP");
            DropIndex("dbo.tb_Sanpham", new[] { "LoaiSps_id" });
            DropColumn("dbo.tb_Sanpham", "maloaisp");
            RenameColumn(table: "dbo.tb_Sanpham", name: "LoaiSps_id", newName: "maloaisp");
            AlterColumn("dbo.tb_Sanpham", "maloaisp", c => c.Int(nullable: false));
            CreateIndex("dbo.tb_Sanpham", "maloaisp");
            AddForeignKey("dbo.tb_Sanpham", "maloaisp", "dbo.tb_LoaiSP", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_Sanpham", "maloaisp", "dbo.tb_LoaiSP");
            DropIndex("dbo.tb_Sanpham", new[] { "maloaisp" });
            AlterColumn("dbo.tb_Sanpham", "maloaisp", c => c.Int());
            RenameColumn(table: "dbo.tb_Sanpham", name: "maloaisp", newName: "LoaiSps_id");
            AddColumn("dbo.tb_Sanpham", "maloaisp", c => c.Int(nullable: false));
            CreateIndex("dbo.tb_Sanpham", "LoaiSps_id");
            AddForeignKey("dbo.tb_Sanpham", "LoaiSps_id", "dbo.tb_LoaiSP", "id");
        }
    }
}
