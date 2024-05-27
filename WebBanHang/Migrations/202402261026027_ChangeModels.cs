namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeModels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Tintuc", "hinhanh", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Tintuc", "tukhoa_seo", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Tintuc", "tieude_seo", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Tintuc", "mieuta_seo", c => c.String(maxLength: 500));
            AlterColumn("dbo.tb_Sanpham", "tensanpham", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.tb_Sanpham", "masanpham", c => c.String(maxLength: 50));
            AlterColumn("dbo.tb_Sanpham", "hinhanh", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Sanpham", "tukhoa_seo", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Sanpham", "tieude_seo", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Sanpham", "mieuta_seo", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Sanpham", "mieuta_seo", c => c.String());
            AlterColumn("dbo.tb_Sanpham", "tieude_seo", c => c.String());
            AlterColumn("dbo.tb_Sanpham", "tukhoa_seo", c => c.String());
            AlterColumn("dbo.tb_Sanpham", "hinhanh", c => c.String());
            AlterColumn("dbo.tb_Sanpham", "masanpham", c => c.String());
            AlterColumn("dbo.tb_Sanpham", "tensanpham", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.tb_Tintuc", "mieuta_seo", c => c.String());
            AlterColumn("dbo.tb_Tintuc", "tieude_seo", c => c.String());
            AlterColumn("dbo.tb_Tintuc", "tukhoa_seo", c => c.String());
            AlterColumn("dbo.tb_Tintuc", "hinhanh", c => c.String());
        }
    }
}
