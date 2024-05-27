namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_DonHang", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_DonHang", "Email");
        }
    }
}
