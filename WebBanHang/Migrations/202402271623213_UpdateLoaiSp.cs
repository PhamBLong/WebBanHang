namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateLoaiSp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_LoaiSP", "tukhoa_seo", c => c.String(maxLength: 250));
            AddColumn("dbo.tb_LoaiSP", "tieude_seo", c => c.String(maxLength: 250));
            AddColumn("dbo.tb_LoaiSP", "mieuta_seo", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_LoaiSP", "mieuta_seo");
            DropColumn("dbo.tb_LoaiSP", "tieude_seo");
            DropColumn("dbo.tb_LoaiSP", "tukhoa_seo");
        }
    }
}
