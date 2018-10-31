using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class TrashE
    {
        [Key]
        public string Name { get; set; }
        [Display(Name = "Customer Bill")]
        public double CustomerBill { get; set; }
        [Display(Name = "Trash pick up status")]
        public string TrashPickUpStatus { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}