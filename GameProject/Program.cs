using GameProject;
using GameProject.Entities;
using GameProject.Abstract;
using GameProject.Concrete;


GamerManager gamerManager = new GamerManager(new UserValiditionManager());
Gamer gamer1 = new Gamer(1, "Tahir", "Darga", new DateTime(1985, 1, 1), 12345);
gamerManager.Add(gamer1);
//gamerManager.Update(gamer1);
//gamerManager.Delete(gamer1);


CampaignManager campaignManager = new CampaignManager();
Campaign campaign1 = new Campaign("İlk Oyunum", 25);
campaignManager.Add(campaign1);


GameManager gameManager1 = new GameManager();
Game game1 = new Game(1, "Call Of Duty", 52);
gameManager1.Add(game1);
gameManager1.Sale(gamer1, game1,campaign1);
//gameManager1.Update(game1);
//gameManager1.Delete(game1);