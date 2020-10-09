using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MyComputerRepairShop.Models;

namespace MyComputerRepairShop.DAL
{
    public class MCRSInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MCRSContext>
    {
        protected override void Seed(MCRSContext context)
        {

            var worker = new List<Worker>
            {
                new Worker{FirstName="Dick", LastName="Flink", FullName="Dick Flink", BirthDate= DateTime.Parse("04-05-1982"), Wage=19.25, Department=Department.Repairs},
                new Worker{FirstName="Rick", LastName="Flink", FullName="Rick Flink", BirthDate= DateTime.Parse("15-06-2000"), Wage=16.25, Department=Department.Office},
                new Worker{FirstName="Gerard", LastName="Janssen", FullName="Gerard Janssen", BirthDate= DateTime.Parse("05-08-2001"), Wage=13.15, Department=Department.Sales}
            };
            worker.ForEach(s => context.workers.Add(s));
            context.SaveChanges();

            var clients = new List<Client>
            {
                new Client {Firstname="Henk", InFix="van", Lastname="Puffellen", Address="Gerrisstraat 6", City="Frederikgidoambacht", Phonenumber="06-11354042", Fullname="Henk van Puffellen"},
                new Client {Firstname="Jan", InFix="",Lastname="Buffeltjes", Address="Plantsoen 3", City="GidoFrederikambacht", Phonenumber="06-57996520", Fullname="Jan Buffeltjes"}
            };
            clients.ForEach(s => context.clients.Add(s));
            context.SaveChanges();

            var computerpart = new List<ComputerPart>
            {
                new ComputerPart{ Name="Ryzen 7", Cateogory=PartCateogory.Other, TotalInStock=5, Stock=Stock.InStock, Vendor=Vendor.AMD, Price=129.75},
                new ComputerPart{ Name="SFX 3", Cateogory=PartCateogory.Geluidskaart, TotalInStock=3, Stock=Stock.InStock, Vendor=Vendor.Asus, Price=119.75}
            };
            computerpart.ForEach(s => context.computerParts.Add(s));
            context.SaveChanges();

            var repairjob = new List<RepairJob>
            {
                new RepairJob{ Name="Computer start niet op", Startdate=DateTime.Now, Enddate=DateTime.Now, Status=Status.Pending, Detail="Het computer start niet, fans draaien wel."},
                new RepairJob{ Name="Scherm defect", Startdate=DateTime.Now, Enddate=DateTime.Now, Status=Status.Pending, Detail="Het scherm valt tijdens gebruik uit" }
            };
            repairjob.ForEach(s => context.repairJobs.Add(s));
            context.SaveChanges();
        }

    }
}