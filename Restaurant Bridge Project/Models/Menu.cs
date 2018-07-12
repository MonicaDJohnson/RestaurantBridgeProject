using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Restaurant_Bridge_Project.Models
{
    public class Menu
    {
        [Key]
        public int MenuID { get; set; }
        public string FiveItems { get; set; }
        public string ItemName { get; set; }
        public string Price { get; set; }
    }
}