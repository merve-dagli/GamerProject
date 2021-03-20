using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamerProject.Abstract;
using GamerProject.Entities;

namespace GamerProject.Concrete
{
     class GamerManager : IGamerServices
    {

        MernisManager _userMernisManager;
        public GamerManager(MernisManager userMernisManager)
        {
            _userMernisManager = userMernisManager;
        }
        

        public void Add(Gamer gamer)
        {
            if (_userMernisManager.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt Eklendi!");
            }
            else
            {
                Console.WriteLine("Kayıt Gerçekleştirilemedi!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi!");
           
        }
    }
    
}
