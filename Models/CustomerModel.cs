using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp_MVC.Models
{
    public class CustomerModel
    {
        [Key]
        [Required(ErrorMessage = "Customer Code is mandatory Field !")]
        public string CustomerCode { get; set; }

        [Required(ErrorMessage ="Customer Name is mandatory Field!")]
        [MinLength(3,ErrorMessage ="Enter Correct Customer Name!")]
        public string CustomerName { get; set; }
        [DataType(DataType.Currency)]
        [Required(ErrorMessage ="Salary is mandatory field!")]
        public int Salary { get; set; }
    }
}