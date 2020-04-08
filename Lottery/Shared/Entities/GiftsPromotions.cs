using System;
using System.Collections.Generic;
using System.Text;

namespace Lottery.Shared.Entities
{
    public class GiftsPromotions
    {
        public int GiftId { get; set; }
        public int PromotionId { get; set; }
        public Gift Gift { get; set; }
        public Promotion Promotion { get; set; }
        public int Order { get; set; }
    }
}
