using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_MVC.Models;

namespace WebApp_MVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            CustomerViewModel customers = new CustomerViewModel();     
            CustomerDal customerDal = new CustomerDal();
            customers.customers = customerDal.customer.OrderByDescending(x => x.CustomerCode).ToList();
            return View(customers);
        }


        [HttpPost]
        public ActionResult Submit(CustomerViewModel _customer)
        {
            if (ModelState.IsValid)
            {
                               
                //DataBase layer to save customer
                CustomerDal customerDal = new CustomerDal();
                customerDal.customer.Add(_customer.customer);
                customerDal.SaveChanges();

                return RedirectToAction("Create");
            }
            else
            {
                return View("Create");
            
            }
          
        }
    }
}