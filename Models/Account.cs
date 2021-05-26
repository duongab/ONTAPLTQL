using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ONTAPLTQL.Models
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        [Required(ErrorMessage = "Username is required")]
        [DisplayName("Ten dang nhap : ")]
        public string Tendangnhap { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [DisplayName("Mat khau :")]
        public string matkhau { get; set; }
        public string RoleID { get; set; }
    }
}