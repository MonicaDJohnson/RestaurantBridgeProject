using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Restaurant_Bridge_Project.Models
{
    public class Customers
    {
        [Key]
        public int CustID { get; set; }
        public string CustName { get; set; }
        public string CustEmail { get; set; }
        public string CustPhone { get; set; }
        public string FavDrink { get; set; }
        public string FavMeal { get; set; }
        public double LargestBill { get; set; }
        public virtual ICollection<Address> Address { get; set; }
    }
}