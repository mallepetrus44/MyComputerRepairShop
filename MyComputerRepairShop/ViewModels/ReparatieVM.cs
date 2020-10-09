using MyComputerRepairShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyComputerRepairShop.ViewModels
{
    public class ReparatieVM
    {
            public RepairJob repairJob { get; set; }
            public List<Client> clients { get; set; }
            public int ClientID { get; set; }

            public List<Worker> workers { get; set; }
            public int WorkerID { get; set; }

            public List<ComputerPart> computerParts { get; set; }
            public int ComputerpartId { get; set; }
    }
}