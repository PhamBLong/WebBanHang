using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    [Table("tb_HinhanhSPs")]
    public class HinhanhSP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [ForeignKey("SanPham")]
        public int ProductID { get; set; }
        public string Image { get; set; }
        public bool isDefault { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}