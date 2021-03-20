using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    class MernisManager : MernisService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.GamerFirstName == "Merve" && gamer.GamerLastName == "Dağlı" && gamer.TcNo == "11111")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
