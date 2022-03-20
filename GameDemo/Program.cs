using GameSalesDemo.Adapters;
using GameSalesDemo.Concrete;
using GameSalesDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MernisCheckAdapter());

            Gamer gamer1  = new Gamer{DateOfBirth = new DateTime(1977, 07, 01), FirstName = "Bülent", LastName = "Baş", 
                NationalityId = "26806793922"};

            Gamer gamer2 = new Gamer{DateOfBirth = new DateTime(1977, 07, 01),FirstName = "Bülent",LastName = "Baş",
                NationalityId = "26806793922"};

            Game game1 = new Game("Spider Man", 150);
            Game game2 = new Game("GTA Vice", 250);

            Campaign campaign = new Campaign(1, "EndOfSeason");
            Campaign campaign2 = new Campaign(2, "SpringSales");

            SalesManager salesManager = new SalesManager();
            SalesManager salesManager2 = new SalesManager();

            if (gamerManager.Add(gamer1))
            {
                Console.WriteLine(gamer1.FirstName + "added ");
                salesManager.Sale(campaign,gamer1);
                salesManager.Sale(campaign2, gamer1);
            }

            if (gamerManager.Add(gamer2))
            {
                Console.WriteLine(gamer2.FirstName + "added ");
                salesManager.Sale(campaign, gamer2);
                salesManager.Sale(campaign2, gamer2);
            }
        }
    }
}
