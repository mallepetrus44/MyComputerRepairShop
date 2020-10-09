using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyComputerRepairShop.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Display(Name = "Voornaam")]
        public string Firstname { get; set; }
        [Display(Name = "tussenvoegel(s)")]
        public string InFix { get; set; }
        [Display(Name = "Achternaam")]
        public string Lastname { get; set; }
        [Display(Name = "Volledige naam")]
        public string Fullname { get; set; }
        [Display(Name = "Telefoonnummer")]
        public string Phonenumber { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
        [Display(Name = "Woonplaats")]
        public string City { get; set; }

        public virtual ICollection<RepairJob> RepairJobs { get; set; }
    }
}