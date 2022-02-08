using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject1
{
    class CampainsManager : ICampeinsManagerService
    {
        public void Add(Campeins campeins)
        {
            Console.WriteLine("Kampanya Eklendi : "+ campeins.CampeinName);
        }

        public void Delete()
        {
            Console.WriteLine("Kampanya Silindi.");
        }

        public void Update()
        {
            Console.WriteLine("Kampanya Güncellendi.");
        }
    }
}
