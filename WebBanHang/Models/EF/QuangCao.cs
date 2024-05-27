using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanHang.Models.EF
{
    [Table("tb_QuangCao")]
    public class QuangCao : CommonAbstract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required(ErrorMessage ="Tiêu đề không được để trống !!")]
        [StringLength(150)]
        public string tieude { get; set; }
        public string mota { get; set; }
        public string alias { get; set; }
        [AllowHtml]
        public string chitietquangcao { get; set; }
        public string hinhanh { get; set; }
        public int MenuID { get; set; }
        public string tukhoa_seo { get; set; }
        public string tieude_seo { get; set; }
        public string mieuta_seo { get; set; }
        public bool isActive { get; set; }
        public virtual Category Category {  get; set; }
    }
}