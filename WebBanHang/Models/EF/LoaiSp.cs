using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    [Table("tb_LoaiSP")]
    public class LoaiSp :CommonAbstract
    {
        public LoaiSp()
        {
            this.SanPhams = new HashSet<SanPham>(); 
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(150)]
        public string Alias { get; set; }
        public string mota { get; set; }

        [StringLength(250)]
        public string icon { get; set; }
        public bool trangthai { get; set; }

        [StringLength(250)]
        public string tukhoa_seo { get; set; }
        [StringLength(250)]
        public string tieude_seo { get; set; }
        [StringLength(500)]
        public string mieuta_seo { get; set; }

        public ICollection<SanPham> SanPhams { get; set; }
    }
}