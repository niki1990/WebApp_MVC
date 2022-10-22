using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp_MVC.Models;

namespace WebApp_MVC
{
    public class CustomerDal:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CustomerModel>().ToTable("CustomerDetails");
        }
        public DbSet<CustomerModel> customer { get; set; }
    }
}