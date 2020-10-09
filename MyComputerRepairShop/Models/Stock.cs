using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyComputerRepairShop.Models
{
    public enum Stock
    {
        None,
        [Display(Name = "Op voorraad")]
        InStock,
        [Display(Name = "Niet op voorraad")]
        OutOfStock,
        [Display(Name = "In bestelling")]
        InOrder

    }
}