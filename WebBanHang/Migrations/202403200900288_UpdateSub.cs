namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSub : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Subscribe", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.tb_Subscribe", "ngaytao");
            DropColumn("dbo.tb_Subscribe", "CreateBy");
            DropColumn("dbo.tb_Subscribe", "CreateDate");
            DropColumn("dbo.tb_Subscribe", "ModifiedDate");
            DropColumn("dbo.tb_Subscribe", "ModifiedBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Subscribe", "ModifiedBy", c => c.String());
            AddColumn("dbo.tb_Subscribe", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Subscribe", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Subscribe", "CreateBy", c => c.String());
            AddColumn("dbo.tb_Subscribe", "ngaytao", c => c.DateTime(nullable: false));
            DropColumn("dbo.tb_Subscribe", "CreatedDate");
        }
    }
}
