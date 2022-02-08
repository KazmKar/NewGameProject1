using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject1
{
    internal class GameManagerService : IGameManagerService 
    {
        

        

        public void Add(Game game)
        {
            Console.WriteLine("Oyun Eklendi  : " + game.GameName); 
        }

        public void Delete()
        {
            Console.WriteLine("Oyun Silindi");
        }

        

        public void Update()
        {
            Console.WriteLine("Oyun Güncellendi");
        }

        
    }
}
