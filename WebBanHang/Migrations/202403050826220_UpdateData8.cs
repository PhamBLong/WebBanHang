namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData8 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.tb_Sanpham", new[] { "LoaiSps_ID" });
            CreateIndex("dbo.tb_Sanpham", "LoaiSps_id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.tb_Sanpham", new[] { "LoaiSps_id" });
            CreateIndex("dbo.tb_Sanpham", "LoaiSps_ID");
        }
    }
}
