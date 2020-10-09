using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyComputerRepairShop.Models
{
    public enum PartCateogory
    {
        None,
        [Display(Name = "Grafische Kaart")]
        GrafischeKaart,
        Geluidskaart,
        Moederbord,
        Geheugen,
        Randapparatuur,
        Other

    }
}