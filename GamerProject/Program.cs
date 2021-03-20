using System;
using GamerProject.Entities;
using GamerProject.Concrete;
using System.Collections;
using System.Collections.Generic;

namespace GamerProject
{
    public class Program
    {
        static void Main(string[] args)
        {

            Gamer gamer1 = new Gamer();
            gamer1.GamerFirstName = "Merve"; 
            gamer1.GamerLastName = "Dağlı";
            gamer1.TcNo = "11111";

            GamerManager gamerManager = new GamerManager(new MernisManager());
            gamerManager.Add(gamer1);
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Gamer gamer2 = new Gamer();
            gamer2.GamerFirstName = "Ali";
            gamer2.GamerLastName = "Işık";
            gamer2.TcNo = "22222";

           

            Store store1 = new Store();
            store1.StoreName = "OnlinePlayStore";

            Store store2 = new Store();
            store2.StoreName = "PlayStore";






                Console.WriteLine("Games: ");

                Game game1 = new Game();
                game1.GameName = "Pes 2021 Season Update PS4";
                game1.GamePrice = 199.00;


                Game game2 = new Game();
                game2.GameName = "GTA 5 PS4";
                game2.GamePrice = 177.00;


                Game game3 = new Game();
                game3.GameName = "NBA 2K21 PS4";
                game3.GamePrice = 295.00;



                Game[] games1 = new Game[] { game1, game2, game3 };

                foreach (var game in games1)
                {
                    Console.WriteLine("Game Name : " + game.GameName + " GamePrice : " + game.GamePrice + " TL");

                }

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Campaigns:");


                Campaign campaign1 = new Campaign();
                campaign1.CampaignName = "Campaign in honor of the Chinese New Year!";
                campaign1.CampaignDiscount = 20;
                Campaign campaign2 = new Campaign();
                campaign2.CampaignName = "Campaign in honor of the Black Friday!";
                campaign2.CampaignDiscount = 30;
                Campaign campaign3 = new Campaign();
                campaign3.CampaignName = "This game has no campaign!";


                CampaignManager campaignManager = new CampaignManager();

                campaignManager.Add(campaign1);
                campaignManager.Add(campaign2);
                campaignManager.Add(campaign3);

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Sales:");

                SalesManager salesManager = new SalesManager();

                salesManager.sales(game1, campaign1, store2,gamer1);
                salesManager.sales(game2, campaign2, store1,gamer2);

            }

            







        }
    }
