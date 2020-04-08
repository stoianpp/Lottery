using Lottery.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lottery.Shared.DTOs
{
    public class DetailsPromotionDTO
    {
        public Promotion Promotion { get; set; }
        public bool Active { get; set; }
        public List<Gift> Gifts { get; set; }
    }
}
