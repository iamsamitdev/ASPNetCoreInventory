using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ASPNetCoreInventory.Models
{
    [ModelMetadataType(typeof(MemberMetadata))]
    public partial class tb_Member
    {
        [NotMapped]
        public string ConfirmPassword { get; set; }
    }

    public class MemberMetadata
    {
        [Display(Name = "ชื่อ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ป้อนชื่อก่อน")]
        public string Member_Firstname { get; set; }

        [Display(Name = "นามสกุล")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ป้อนนามสกุลก่อน")]
        public string Member_Lastname { get; set; }

        [Display(Name = "อีเมล์")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ป้อนอีเมล์ก่อน")]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Member_Email { get; set; }

        [Display(Name = "รหัสผ่าน")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ป้อนรหัสผ่านก่อน")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "รหัสผ่านขั้นต่ำ 6 ตัวอักษร")]
        public string Member_Password { get; set; }

        [Display(Name = "ยืนยันรหัสผ่าน")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ป้อนรหัสผ่านยืนยันก่อน")]
        [DataType(DataType.Password)]
        [Compare("Member_Password", ErrorMessage = "รหัสผ่านไม่ตรงกัน")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "วันเกิด")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ป้อนวันเกิดก่อน")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Member_Birthdate { get; set; }

    }
}
