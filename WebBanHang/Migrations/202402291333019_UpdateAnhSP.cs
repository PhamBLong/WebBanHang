namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAnhSP : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_AnhSP",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AnhID = c.Int(nullable: false),
                        Anh = c.String(),
                        isDefault = c.Boolean(nullable: false),
                        SanPham_id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tb_Sanpham", t => t.SanPham_id)
                .Index(t => t.SanPham_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_AnhSP", "SanPham_id", "dbo.tb_Sanpham");
            DropIndex("dbo.tb_AnhSP", new[] { "SanPham_id" });
            DropTable("dbo.tb_AnhSP");
        }
    }
}
