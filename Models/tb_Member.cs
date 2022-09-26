using System;
using System.Collections.Generic;

#nullable disable

namespace ASPNetCoreInventory.Models
{
    public partial class tb_Member
    {
        public int Member_ID { get; set; }
        public string Member_Firstname { get; set; }
        public string Member_Lastname { get; set; }
        public string Member_Email { get; set; }
        public string Member_Password { get; set; }
        public DateTime Member_Birthdate { get; set; }
        public int Member_Type { get; set; }
        public int Member_Status { get; set; }
    }
}
