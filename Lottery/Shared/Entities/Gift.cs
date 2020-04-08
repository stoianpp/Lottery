using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lottery.Shared.Entities
{
    public class Gift
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string OwnerId { get; set; }
        public List<GiftsPromotions> GiftsPromotions { get; set; } = new List<GiftsPromotions>();
    }
}
