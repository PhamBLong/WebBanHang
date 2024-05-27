using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    [Table("tb_ChitietDonhang")]
    public class ChiTietDH
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("DonHang")]
        public int OrderId { get; set; }
      
        [ForeignKey("SanPham")]
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public virtual DonHang DonHang { get; set; }    
        public virtual SanPham  SanPham { get; set; }
    }
}