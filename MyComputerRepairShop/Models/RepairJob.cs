using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyComputerRepairShop.Models
{
    public class RepairJob
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Opdracht omschrijving")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [Display(Name = "Startdatum")]
        public DateTime Startdate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [Display(Name = "Einddatum")]
        public DateTime Enddate { get; set; }
        [Display(Name="Details")]
        public string Detail { get; set; }
        public Status Status { get; set; }

        public virtual Client Client { get; set; }

        public virtual Worker Worker { get; set; }

        public virtual ICollection<ComputerPart> ComputerParts { get; set; }
    }
}