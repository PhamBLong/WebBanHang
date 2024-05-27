using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanHang.Models.EF
{
    [Table("tb_Tintuc")]
    public class TinTuc : CommonAbstract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required(ErrorMessage ="Tiêu đề không thể trống !!")]
        [StringLength(150)]
        public string tieude { get; set; }
        public string alias { get; set; }
        public string mota { get; set; }

        [AllowHtml]
        public string chitiet { get; set; }
        [StringLength(250)]
        public string hinhanh { get; set; }
        public int MenuID { get; set; }
        [StringLength(250)]
        public string tukhoa_seo { get; set; }
        [StringLength(250)]
        public string tieude_seo { get; set; }
        [StringLength(500)]
        public string mieuta_seo { get; set; }
        public bool isActive { get; set; }
        public virtual Category Category { get; set; }
    }
}