using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanHang.Models.EF
{
    [Table("tb_Sanpham")]
    public class SanPham : CommonAbstract
    {
        public SanPham() 
        {
            this.HinhanhSPs = new HashSet<HinhanhSP>();
            this.ChiTietDHs = new HashSet<ChiTietDH>();
            this.Reviews = new HashSet<ReviewProduct>();
            this.Wishlists = new HashSet<Wishlist>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int id { get; set; }
        [Required]
        [StringLength(250)]
        public string tensanpham { get; set; }
        [StringLength(250)]
        public string alias { get; set; }

        [StringLength(50)]
        public string masanpham { get; set; }
        [ForeignKey("LoaiSps")]
        public int maloaisp { get; set; }
        public string mota { get; set; }
        [AllowHtml]
        public string chitietsanpham { get; set; }

        [StringLength(250)]
        public string hinhanh { get; set; }
        public decimal OriginalPrice { get; set; }
        public bool trangthai { get; set; }
        public decimal gia { get; set; }
        public decimal ? khuyenmai { get; set; }
        public int soluong { get; set; }
        public int ViewCount { get; set; }
        public bool isHome { get; set; }
        public bool isSale { get; set; }
        public bool isFeature { get; set; }
        public bool isHot { get; set; }
        public bool isActive { get; set; }
        [StringLength(250)]
        public string tukhoa_seo { get; set; }
        [StringLength(250)]
        public string tieude_seo { get; set; }
        [StringLength(500)]
        public string mieuta_seo { get; set; }


        public virtual LoaiSp LoaiSps { get; set; }  
        public virtual ICollection<HinhanhSP> HinhanhSPs { get; set; }
        public virtual ICollection<ChiTietDH> ChiTietDHs { get; set; }
        public virtual ICollection<ReviewProduct> Reviews { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }

    }
}