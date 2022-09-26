using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreInventory.Models
{
    [ModelMetadataType(typeof(UserMetadata))]
    public partial class User
    {
        [NotMapped]
        public string ConfirmPassword { get; set; }
    }

    public class UserMetadata
    {
        [Display(Name = "ชื่อ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ป้อนชื่อก่อน")]
        public string FirstName { get; set; }

        [Display(Name = "นามสกุล")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ป้อนนามสกุลก่อน")]
        public string LastName { get; set; }

        [Display(Name = "อีเมล์")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ป้อนอีเมล์ก่อน")]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }

        [Display(Name = "วันเกิด")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "รหัสผ่าน")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ป้อนรหัสผ่านก่อน")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "รหัสผ่านต้องไม่ต่ำกว่า 6 ตัวอักษร")]
        public string Password { get; set; }

        [Display(Name = "ยืนยันรหัสผ่าน")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ป้อนรหัสผ่านยืนยันก่อน")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "รหัสผ่านยืนยันไม่ตรงกัน")]
        public string ConfirmPassword { get; set; }
    }


}
