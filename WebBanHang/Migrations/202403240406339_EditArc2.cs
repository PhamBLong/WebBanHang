namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditArc2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Baiviet", "MenuID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Baiviet", "MenuID");
        }
    }
}
