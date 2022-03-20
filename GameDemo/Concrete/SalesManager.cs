using GameSalesDemo.Abstract;
using GameSalesDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesDemo.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sale(Campaign campaign, Gamer gamer)
        {
            Console.WriteLine("Made Sale to " + gamer.FirstName + "with " + campaign.CampaignName);
        }

    }
}
