namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Sanpham", "alias", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Sanpham", "alias", c => c.String());
        }
    }
}
