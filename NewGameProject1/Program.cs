using DocuSign.eSign.Model;
using System;

namespace NewGameProject1
{
    class Program
    {
        static void Main(string[] args)
        {

            Gamer gamer2 = new Gamer();
            gamer2.BirthYear = 1888;
            gamer2.FirstName = "Heinz";
            gamer2.LastName = "Guderian";
            gamer2.IdentityNumber = 123654;

            GamerManager gamerManager2 = new GamerManager(new NewEStateUserVerficationManager());
            gamerManager2.Delete(gamer2);


            GamerManager gamerManager = new GamerManager(new NewEStateUserVerficationManager());
            gamerManager.Add(new Gamer 
            {
                Id = 1,
                BirthYear = 2003,
                FirstName = "Kazım",
                LastName = "Kar",
                IdentityNumber = 123456

            });




            Game game = new Game();
            game.GameId = 1;
            game.GameName = "Hoi4";
            game.UnitPrice = 60;

            GameManagerService gameManagerService = new GameManagerService();
            gameManagerService.Add(game);
            


            Campeins campeins = new Campeins();
            campeins.CampeinId = 1;
            campeins.CampeinName = "Black Friday";
            campeins.CampeinPrice = game.UnitPrice %45;

            CampainsManager campainsManager = new CampainsManager();
            campainsManager.Add(campeins);
            




            
            
            
        }
    }
}
