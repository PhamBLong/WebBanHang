namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Menu", "alias", c => c.String());
            AddColumn("dbo.tb_Tintuc", "alias", c => c.String());
            AddColumn("dbo.tb_Sanpham", "alias", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Sanpham", "alias");
            DropColumn("dbo.tb_Tintuc", "alias");
            DropColumn("dbo.tb_Menu", "alias");
        }
    }
}
