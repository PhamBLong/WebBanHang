namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData4 : DbMigration
    {
        public override void Up()
        {
          
            AddColumn("dbo.HinhanhSPs", "SanPham_id", c => c.Int());
            CreateIndex("dbo.HinhanhSPs", "SanPham_id");
            AddForeignKey("dbo.HinhanhSPs", "SanPham_id", "dbo.tb_Sanpham", "id");
           
        }
        
        public override void Down()
        {
           
            DropForeignKey("dbo.HinhanhSPs", "SanPham_id", "dbo.tb_Sanpham");
            DropIndex("dbo.HinhanhSPs", new[] { "SanPham_id" });
            DropColumn("dbo.HinhanhSPs", "SanPham_id");
            CreateIndex("dbo.tb_AnhSP", "SanPham_id");
            AddForeignKey("dbo.tb_AnhSP", "SanPham_id", "dbo.tb_Sanpham", "id");
        }
    }
}
