using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamerProject.Abstract;
using GamerProject.Concrete;
using GamerProject.Entities;


namespace GamerProject.Entities
{
    public class Campaign : IEntity
    {
        public string CampaignName { get; set; }
        public int CampaignDiscount { get; set; }

    }
}
