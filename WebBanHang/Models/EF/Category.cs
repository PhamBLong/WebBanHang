using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    [Table("tb_Menu")]
    public class Category : CommonAbstract
    {
        public Category () 
        {
            this.TinTuc = new HashSet<TinTuc>();
           this.Arcticle = new HashSet<Arcticle>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Không được để trống")]
        [StringLength(150)]
        public string tieude { get; set; }
        public string alias { get; set; }

        //[StringLength(150)]
        //public string TypeCode { get; set; }
        public string Link { get; set; }

        [StringLength(250)]
        public string tukhoa_seo { get; set; }
        [StringLength(250)]
        public string tieude_seo { get; set; }

        [StringLength(550)]
        public string mieuta_seo { get; set; }
        public int chucvu { get; set; }

        [StringLength(500)]
        public string mota { get; set; }
        public bool isActive { get; set; }

        public ICollection<TinTuc> TinTuc { get; set;}
       
        public ICollection<Arcticle> Arcticle { get; set;}
    }
}