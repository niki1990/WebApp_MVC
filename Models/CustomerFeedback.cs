using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp_MVC.Models
{
    public class CustomerFeedback
    {
        [Key]
        public int FeedbackID { get; set; }

        [Required]
        public string Feedback { get; set; }
    }
}