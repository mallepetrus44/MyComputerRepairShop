using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyComputerRepairShop.Models
{
    public enum Department
    {
        None,
        [Display(Name = "Reparaties")]
        Repairs,
        [Display(Name = "Services")]
        AfterSales,
        [Display(Name = "Verkoop")]
        Sales,
        [Display(Name = "Kantoor")]
        Office
    }
}
