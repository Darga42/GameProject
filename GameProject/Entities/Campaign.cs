using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    public class Campaign : IEntity
    {
        public Campaign(string campaignName, float campaignPercentage)
        {
            CampaignName = campaignName;
            CampaignPercentage = campaignPercentage;
        }
        public float CampaignPercentage { get; set; }
        public string CampaignName { get; set; }
    }
}
