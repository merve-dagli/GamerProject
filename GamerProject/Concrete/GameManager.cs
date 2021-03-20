using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{
    public class GameManager : IGameServices
    {
       

        public void Add(Game game)
        {
            Console.WriteLine(game.GameName, game.GamePrice);
        }

      

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName, game.GamePrice);
        }

       

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName, game.GamePrice);
        }
    }
}