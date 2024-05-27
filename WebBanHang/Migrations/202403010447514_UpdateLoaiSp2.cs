﻿namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateLoaiSp2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_LoaiSP", "ten", c => c.String(nullable: false, maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_LoaiSP", "ten", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
