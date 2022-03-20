using GameSalesDemo.Abstract;
using GameSalesDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        ICheckGamerService _checkGamerService;

        public GamerManager(ICheckGamerService checkGamerService)
        {
            _checkGamerService = checkGamerService;
        }

        public bool Add(Gamer gamer)
        {
            if(_checkGamerService.CheckIfRealPerson(gamer))
            {
                return true;
            }
            else
            {
                throw new NotImplementedException("Not a valid Person");
            }
        }

        public void Delete(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void Update(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
