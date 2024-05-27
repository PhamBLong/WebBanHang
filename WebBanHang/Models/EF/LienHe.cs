using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    [Table("tb_Lienhe")]
    public class LienHe : CommonAbstract
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required(ErrorMessage = "Thông tin không được để trống")]
        [StringLength(150, ErrorMessage = "Không được vượt quá 150 kí tự")]
        public string hoten { get; set; }
        public string tieude { get; set; }

        [StringLength(150)]
        public string email { get; set; }
        [StringLength(4000)]
        public string messages { get; set; }
        public bool isRead { get; set; }
    }
}