using GameSalesDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesDemo.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UnitPrice { get; set; }

        public Game(string name, int unitPrice)
        {
            Name = name;
            UnitPrice = unitPrice;
        }
    }
}
