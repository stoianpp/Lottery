using Lottery.Shared.DTOs;
using Lottery.Shared.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lottery.Client.Repository
{
    public interface IGiftRepository
    {
        Task CreateGift(Gift gift);
        Task DeleteGift(int Id);
        Task<List<Gift>> GetAll();
        Task<Gift> GetGiftById(int id);
        Task<PaginatedResponse<List<Gift>>> GetGifts(PaginationDTO paginationDTO);
        Task<List<Gift>> GetGiftsByName(string name);
        Task<List<Gift>> GetGiftsByPromotion(Promotion promotion);
        Task UpdateGift(Gift gift);
    }
}