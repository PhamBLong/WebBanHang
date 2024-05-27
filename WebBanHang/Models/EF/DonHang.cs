using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    [Table("tb_DonHang")]
    public class DonHang:CommonAbstract
    {
        public DonHang() 
        {
            this.ChiTietDHs = new HashSet<ChiTietDH>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required (ErrorMessage ="Tên khách hàng không được để trống !!")]
        public string CustomerName { get; set; }
      
        [Required (ErrorMessage = "Số điện thoại không được để trống !!")]
        public string sodienthoai { get; set; }
        public string Email { get; set; }
        public decimal TotalAmount {  get; set; }
        [Required (ErrorMessage = "Địa chỉ không được để trống !!")]
        public string diachi { get; set; }
        public int Quantity {  get; set; }
        public int TypePayment { get; set; }
        public int Status { get; set; }
        public string CustomerId { get; set; }

        public virtual ICollection<ChiTietDH> ChiTietDHs { get; set; }

    }
}