using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class TrashC
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        [Display(Name = "Days of pickup")]
       
        public string Days { get; set; }       
        [Display(Name = "Start date of suspension")]
        public DateTime? StartDate { get; set; }
        [Display(Name = "End date of suspension")]
        public DateTime? EndDate { get; set; }
        [Display(Name = "Request an extra pick up day")]
        public DateTime? ExtraPickUp { get; set; }
        public double Bill { get; set; }
        public string Status { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }



    }
}