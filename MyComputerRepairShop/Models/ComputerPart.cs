using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyComputerRepairShop.Models
{
    public class ComputerPart
    {
        public int Id { get; set; }

        [Display(Name = "Naam")]
        public string Name { get; set; }

        [Display(Name = "Fabrikant")]
        public Vendor Vendor { get; set; }

        [Display(Name = "Cateogorie")]
        public PartCateogory Cateogory { get; set; }

        [Display(Name = "Aantal op voorraad")]
        public int TotalInStock { get; set; }

        [Display(Name = "Voorraad status")]
        public Stock Stock { get; set; }

        [Display(Name = "Prijs")]
        public double Price { get; set; }

        public virtual ICollection<RepairJob> RepairJobs { get; set; }
    }
}