using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyComputerRepairShop.Models
{
    public enum Status
    {
        None,
        [Display(Name = "Wordt aan gewerkt")]
        Pending,
        [Display(Name = "Afgerond")]
        Completed,
        [Display(Name = "Vertraagd")]
        Delayed
    }
}