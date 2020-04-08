using Lottery.Shared.DTOs;
using Lottery.Shared.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lottery.Client.Repository
{
    public interface IPromotionRepository
    {
        Task CreatePromotion(Promotion promotion);
        Task DeletePromotion(int Id);
        Task<Promotion> GetPromotionById(int id);
        Task<PromotionUpdateDTO> GetPromotionForUpdate(int id);
        Task<PaginatedResponse<List<Promotion>>> GetPromotions(PaginationDTO paginationDTO);
        Task<List<Promotion>> GetPromotionsByName(string name);
        Task UpdatePromotion(Promotion promotion);
    }
}