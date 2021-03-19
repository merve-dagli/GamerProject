using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamerProject.Entities;

namespace GamerProject.Abstract
{
    public interface IGameServices
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
