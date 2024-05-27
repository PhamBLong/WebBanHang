namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateLoaiSp1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_LoaiSP", "alias", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_LoaiSP", "icon", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_LoaiSP", "icon", c => c.String());
            DropColumn("dbo.tb_LoaiSP", "alias");
        }
    }
}
