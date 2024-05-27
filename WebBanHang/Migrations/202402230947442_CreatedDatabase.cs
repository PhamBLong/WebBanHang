namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_Adv",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tieude = c.String(nullable: false, maxLength: 250),
                        mota = c.String(maxLength: 500),
                        hinhanh = c.String(),
                        kieu = c.Int(nullable: false),
                        link = c.String(maxLength: 500),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.tb_Menu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        tieude = c.String(nullable: false, maxLength: 150),
                        tukhoa_seo = c.String(maxLength: 250),
                        tieude_seo = c.String(maxLength: 250),
                        mieuta_seo = c.String(maxLength: 550),
                        chucvu = c.Int(nullable: false),
                        mota = c.String(maxLength: 500),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tb_Tintuc",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tieude = c.String(),
                        mota = c.String(),
                        hinhanh = c.String(),
                        MenuID = c.Int(nullable: false),
                        tukhoa_seo = c.String(),
                        tieude_seo = c.String(),
                        mieuta_seo = c.String(),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.tb_Menu", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.tb_ChitietDonhang",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        id_donhang = c.Int(nullable: false),
                        gia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tongsoluong = c.String(),
                        DonHang_Id = c.Int(),
                        SanPham_id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tb_DonHang", t => t.DonHang_Id)
                .ForeignKey("dbo.tb_Sanpham", t => t.SanPham_id)
                .Index(t => t.DonHang_Id)
                .Index(t => t.SanPham_id);
            
            CreateTable(
                "dbo.tb_DonHang",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        madonhang = c.String(nullable: false),
                        tenKhachhang = c.String(nullable: false),
                        ngaydathang = c.DateTime(nullable: false),
                        sodienthoai = c.String(nullable: false),
                        ghichu = c.String(),
                        diachi = c.String(nullable: false),
                        soluong = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tb_Sanpham",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tensanpham = c.String(nullable: false, maxLength: 50),
                        madonhang = c.String(),
                        mota = c.String(),
                        hinhanh = c.String(),
                        trangthai = c.Boolean(nullable: false),
                        gia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        chitietsanpham = c.String(),
                        soluong = c.Int(nullable: false),
                        isHome = c.Boolean(nullable: false),
                        isSale = c.Boolean(nullable: false),
                        isFeature = c.Boolean(nullable: false),
                        tukhoa_seo = c.String(),
                        tieude_seo = c.String(),
                        mieuta_seo = c.String(),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        LoaiSp_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.tb_LoaiSP", t => t.LoaiSp_id)
                .Index(t => t.LoaiSp_id);
            
            CreateTable(
                "dbo.tb_LoaiSP",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ten = c.String(nullable: false, maxLength: 50),
                        mota = c.String(),
                        icon = c.String(),
                        trangthai = c.Boolean(nullable: false),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.HinhanhSPs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        id_sanpham = c.Int(nullable: false),
                        hinhanh = c.String(),
                        isDefault = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tb_Lienhe",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        hoten = c.String(nullable: false, maxLength: 150),
                        tieude = c.String(),
                        email = c.String(maxLength: 150),
                        messages = c.String(maxLength: 4000),
                        isRead = c.Boolean(nullable: false),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.tb_Subscribe",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        email = c.String(),
                        ngaytao = c.DateTime(nullable: false),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(),
                        Phone = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.tb_ChitietDonhang", "SanPham_id", "dbo.tb_Sanpham");
            DropForeignKey("dbo.tb_Sanpham", "LoaiSp_id", "dbo.tb_LoaiSP");
            DropForeignKey("dbo.tb_ChitietDonhang", "DonHang_Id", "dbo.tb_DonHang");
            DropForeignKey("dbo.tb_Tintuc", "Category_Id", "dbo.tb_Menu");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.tb_Sanpham", new[] { "LoaiSp_id" });
            DropIndex("dbo.tb_ChitietDonhang", new[] { "SanPham_id" });
            DropIndex("dbo.tb_ChitietDonhang", new[] { "DonHang_Id" });
            DropIndex("dbo.tb_Tintuc", new[] { "Category_Id" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.tb_Subscribe");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.tb_Lienhe");
            DropTable("dbo.HinhanhSPs");
            DropTable("dbo.tb_LoaiSP");
            DropTable("dbo.tb_Sanpham");
            DropTable("dbo.tb_DonHang");
            DropTable("dbo.tb_ChitietDonhang");
            DropTable("dbo.tb_Tintuc");
            DropTable("dbo.tb_Menu");
            DropTable("dbo.tb_Adv");
        }
    }
}
