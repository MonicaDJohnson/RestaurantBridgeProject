using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Restaurant_Bridge_Project.Models
{
    public class Employees
    {
        [Key]
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpEmail { get; set; }
        public string EmpPhone { get; set; }
        public string EmpNumber { get; set; }
        public string EmerConName { get; set; }
        public string EmerConNumber { get; set; }
        public string DateStarted { get; set; }
    }
}