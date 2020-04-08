using System;
using System.Collections.Generic;
using System.Text;

namespace Lottery.Shared.Entities
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public string Description { get; set; }
        public string OwnerId { get; set; }
        public List<GiftsPromotions> GiftsPromotions { get; set; } = new List<GiftsPromotions>();
    }
}
