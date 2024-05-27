namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateArcticle1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_Baiviet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        Alias = c.String(),
                        Description = c.String(),
                        Detail = c.String(),
                        Image = c.String(maxLength: 250),
                        SeoKeyWord = c.String(maxLength: 250),
                        SeoTitle = c.String(maxLength: 250),
                        SeoDesc = c.String(maxLength: 500),
                        isActive = c.Boolean(nullable: false),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_Menu", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_Baiviet", "Category_Id", "dbo.tb_Menu");
            DropIndex("dbo.tb_Baiviet", new[] { "Category_Id" });
            DropTable("dbo.tb_Baiviet");
        }
    }
}
