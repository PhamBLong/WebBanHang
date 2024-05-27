namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData61 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_DonHang", "CreateBy", c => c.String());
            AddColumn("dbo.tb_DonHang", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_DonHang", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_DonHang", "ModifiedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_DonHang", "ModifiedBy");
            DropColumn("dbo.tb_DonHang", "ModifiedDate");
            DropColumn("dbo.tb_DonHang", "CreateDate");
            DropColumn("dbo.tb_DonHang", "CreateBy");
        }
    }
}
