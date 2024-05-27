namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData71 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_DonHang", "ngaydathang");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_DonHang", "ngaydathang", c => c.DateTime(nullable: false));
        }
    }
}
