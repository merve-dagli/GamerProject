using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamerProject.Abstract;
using GamerProject.Entities;

namespace GamerProject.Entities
{
    public class Game : IEntity
    {

        public string GameName { get; set; } 
        public double GamePrice { get; set; }

    }
}
