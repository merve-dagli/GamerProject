using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using GamerProject.Concrete;
using GamerProject.Abstract;

namespace GamerProject.Concrete
{
    public class CampaignManager : ICampaignServices
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + " % " + campaign.CampaignDiscount);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + " % " + campaign.CampaignDiscount);
        }
    }

}
