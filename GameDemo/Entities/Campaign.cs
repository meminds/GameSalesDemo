using GameSalesDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesDemo.Entities
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public Campaign (int id, string campaignName)
        {
            Id = id;
            CampaignName = campaignName;
        }
    }
}
