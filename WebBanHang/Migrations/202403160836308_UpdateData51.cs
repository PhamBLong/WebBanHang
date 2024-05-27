namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData51 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_DonHang", "TypePayment", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_DonHang", "TypePayment");
        }
    }
}
