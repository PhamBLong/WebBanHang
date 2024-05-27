using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    [Table("tb_Setting")]
    public class SystemSetting
    {
        [Key]
        [StringLength(50)]
        public string settingKeys { get; set; }
        [MaxLength]
        public string settingValue { get; set; }
        [StringLength(250)]
        public string settingDescp { get; set; }
    }
}