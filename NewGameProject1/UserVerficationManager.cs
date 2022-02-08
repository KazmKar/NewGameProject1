using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject1
{
    class UserVerficationManager : IUserVerficationService
    {
        public bool Verfication(Gamer gamer2)
        {
            if (gamer2.BirthYear == 2003 && gamer2.FirstName == "Kazım" && gamer2.LastName == "Kar" &&
                gamer2.IdentityNumber == 123456)
            {
                Console.WriteLine("Doğrulama başarılı");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
