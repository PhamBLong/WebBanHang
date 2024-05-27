namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData6 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.tb_Sanpham", name: "LoaiSp_id", newName: "LoaiSps_id");
            RenameIndex(table: "dbo.tb_Sanpham", name: "IX_LoaiSp_id", newName: "IX_LoaiSps_id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.tb_Sanpham", name: "IX_LoaiSps_id", newName: "IX_LoaiSp_id");
            RenameColumn(table: "dbo.tb_Sanpham", name: "LoaiSps_id", newName: "LoaiSp_id");
        }
    }
}
