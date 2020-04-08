using Lottery.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lottery.Shared.DTOs
{
    public class PromotionUpdateDTO
    {
        public Promotion Promotion { get; set; }
        public bool Active { get; set; }
        public List<Gift> SelectedGifts { get; set; }
        public List<Gift> NotSelectedGifts { get; set; }
    }
}
