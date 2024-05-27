namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData13 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tb_ChitietDonhang", "DonHang_Id", "dbo.tb_DonHang");
            DropIndex("dbo.tb_ChitietDonhang", new[] { "DonHang_Id" });
            DropColumn("dbo.tb_ChitietDonhang", "OrderId");
            RenameColumn(table: "dbo.tb_ChitietDonhang", name: "DonHang_Id", newName: "OrderId");
            AlterColumn("dbo.tb_ChitietDonhang", "OrderId", c => c.Int(nullable: false));
            CreateIndex("dbo.tb_ChitietDonhang", "OrderId");
            AddForeignKey("dbo.tb_ChitietDonhang", "OrderId", "dbo.tb_DonHang", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_ChitietDonhang", "OrderId", "dbo.tb_DonHang");
            DropIndex("dbo.tb_ChitietDonhang", new[] { "OrderId" });
            AlterColumn("dbo.tb_ChitietDonhang", "OrderId", c => c.Int());
            RenameColumn(table: "dbo.tb_ChitietDonhang", name: "OrderId", newName: "DonHang_Id");
            AddColumn("dbo.tb_ChitietDonhang", "OrderId", c => c.Int(nullable: false));
            CreateIndex("dbo.tb_ChitietDonhang", "DonHang_Id");
            AddForeignKey("dbo.tb_ChitietDonhang", "DonHang_Id", "dbo.tb_DonHang", "Id");
        }
    }
}
