using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    public class SalesManager : ISalesServices
    {

        public void sales(Game game, Campaign campaign,Store store,Gamer gamer)
        {

            double discount = game.GamePrice;

            if (gamer.GamerFirstName == "Merve" && gamer.GamerLastName == "Dağlı" && gamer.TcNo == "11111")
            {
                if (campaign.CampaignDiscount == 20)
                {
                    discount = (discount * 0.80);

                    Console.WriteLine("Sn. " + gamer.GamerFirstName + " için " + game.GameName + " isimli oyun " + game.GamePrice + " TL'den " + " % " + campaign.CampaignDiscount + " " + campaign.CampaignName + " ile " + discount + " TL fiyata " + store.StoreName + " üzerinden satışı gerçekleşmiştir.");
                }
                else if (campaign.CampaignDiscount == 30)
                {
                    discount = (discount * 0.70);
                    Console.WriteLine("Sn. "+gamer.GamerFirstName + " için " + game.GameName + " isimli oyun " + game.GamePrice + " TL'den " + " % " + campaign.CampaignDiscount + " " + campaign.CampaignName + " ile " + discount + " TL fiyata " + store.StoreName + " üzerinden satışı gerçekleşmiştir.");

                }
                else
                {

                    Console.WriteLine("Sn. " + gamer.GamerFirstName + " için " + game.GameName + " isimli oyun " + game.GamePrice + " TL fiyata " + store.StoreName + " üzerinden satışı gerçekleşmiştir." + " " + campaign.CampaignName);
                }
            }
            else
            {
                Console.WriteLine(gamer.GamerFirstName+" "+gamer.GamerLastName+" isimli kayıt bulunamamıştır.");
            }
            }



          

        }
    }


