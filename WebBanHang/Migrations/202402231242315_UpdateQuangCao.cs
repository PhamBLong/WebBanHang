namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateQuangCao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_QuangCao",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tieude = c.String(nullable: false, maxLength: 150),
                        alias = c.String(),
                        chitietquangcao = c.String(),
                        hinhanh = c.String(),
                        MenuID = c.Int(nullable: false),
                        tukhoa_seo = c.String(),
                        tieude_seo = c.String(),
                        mieuta_seo = c.String(),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.tb_Menu", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_QuangCao", "Category_Id", "dbo.tb_Menu");
            DropIndex("dbo.tb_QuangCao", new[] { "Category_Id" });
            DropTable("dbo.tb_QuangCao");
        }
    }
}
