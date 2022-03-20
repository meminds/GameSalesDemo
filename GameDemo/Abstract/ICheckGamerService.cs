using GameSalesDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesDemo.Abstract
{
    public interface ICheckGamerService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
