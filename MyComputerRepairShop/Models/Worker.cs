using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyComputerRepairShop.Models
{
    public class Worker
    {
        public int Id { get; set; }
        [Display(Name = "Voornaam")]
        public string FirstName { get; set; }
        [Display(Name = "Tussenvoegsel(s)")]
        public string Infix { get; set; }
        [Display(Name = "Achternaam")]
        public string LastName { get; set; }
        [Display(Name = "Volledige naam")]
        public string FullName { get; set; } 
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Geboortedatum")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Uurloon")]
        public double Wage { get; set; }
        [Display(Name = "Afdeling")]
        public Department Department { get; set; }

        public virtual ICollection<RepairJob> RepairJobs { get; set; }
    }
}