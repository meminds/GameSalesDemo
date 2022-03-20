using GameSalesDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesDemo.Abstract
{
    public interface ISalesService
    {
        void Sale(Campaign campaign, Gamer gamer);
    }
}
