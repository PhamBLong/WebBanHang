namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_ChitietDonhang", "id_sanpham", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_ChitietDonhang", "id_sanpham");
        }
    }
}
