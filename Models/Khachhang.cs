using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ONTAPLTQL.Models
{
    [Table("Khachhangs")]
    public class Khachhang
    {
        [Key]
        [DisplayName("Ma khach hang :")]
        public string makh { get; set; }
        [DisplayName("Ten khach hang :")]
        public string tenkh { get; set; }
        [DisplayName("So dien thoai :")]
        public string sdt { get; set;}
        [AllowHtml]
        [DisplayName("Email :")]
        public string email { get; set; }
    }

}