using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
        [Table("tb_Adv")]
        public class Adv : CommonAbstract
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int id { get; set; }
            [Required]
            [StringLength(250)]
            public string tieude { get; set; }
            [StringLength(500)]
            public string mota { get; set; }
            [MaxLength]
            public string hinhanh { get; set; }
            public int kieu { get; set; }
            [StringLength(500)]
            public string link { get; set; }
        }
}