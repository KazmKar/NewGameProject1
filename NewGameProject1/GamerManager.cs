using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject1
{
    class GamerManager : IGamerService
    {
        IUserVerficationService _userVerficationService;

        public GamerManager(IUserVerficationService userVerficationService)
        {
            _userVerficationService = userVerficationService;
        }

        

        public void Add(Gamer gamer)
        {
            if (_userVerficationService.Verfication(gamer)==true)
            {
                Console.WriteLine("Oyuncu Kaydı Başarılı : " + gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Oyunucu Kaydı Başarısız. Doğrulama Başarısız.");

            }
        }

        

        public void Delete(Gamer gamer2)
        {
            Console.WriteLine("Oyuncu Kaydı Silindi : " + gamer2.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi.");
        }
    }
}
