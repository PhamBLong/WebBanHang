namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_DonHang", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.tb_DonHang", "CustomerId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_DonHang", "CustomerId");
            DropColumn("dbo.tb_DonHang", "Status");
        }
    }
}
