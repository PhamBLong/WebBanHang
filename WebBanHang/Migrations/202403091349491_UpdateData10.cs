namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_Setting",
                c => new
                    {
                        settingKeys = c.String(nullable: false, maxLength: 50),
                        settingValue = c.String(),
                        settingDescp = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.settingKeys);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tb_Setting");
        }
    }
}
