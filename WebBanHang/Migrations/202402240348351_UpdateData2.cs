namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_QuangCao", "CreateBy", c => c.String());
            AddColumn("dbo.tb_QuangCao", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_QuangCao", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_QuangCao", "ModifiedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_QuangCao", "ModifiedBy");
            DropColumn("dbo.tb_QuangCao", "ModifiedDate");
            DropColumn("dbo.tb_QuangCao", "CreateDate");
            DropColumn("dbo.tb_QuangCao", "CreateBy");
        }
    }
}
