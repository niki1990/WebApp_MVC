using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_MVC.Models
{
    public class CustomerViewModel
    {
        public CustomerViewModel()
        {

        }
        public CustomerModel customer { get; set; }
        public List<CustomerModel> customers { get; set; }
    }
}