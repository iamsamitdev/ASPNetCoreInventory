using System;
using System.Collections.Generic;

#nullable disable

namespace ASPNetCoreInventory.Models
{
    public partial class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int CategoryStatus { get; set; }
    }
}
