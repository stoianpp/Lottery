using AutoMapper;
using Lottery.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lottery.Server.Helpers
{
    public class AutomapperProfiles: Profile
    {
        public AutomapperProfiles()
        {
           // CreateMap<Gift, Gift>()
           //     .ForMember(x => x.Picture, option => option.Ignore());
        }
    }
}
