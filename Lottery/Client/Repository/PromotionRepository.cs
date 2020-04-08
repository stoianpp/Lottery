using Lottery.Client.Helpers;
using Lottery.Shared.DTOs;
using Lottery.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lottery.Client.Repository
{
    public class PromotionRepository : IPromotionRepository
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/promotions";

        public PromotionRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<PaginatedResponse<List<Promotion>>> GetPromotions(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<Promotion>>(url, paginationDTO);
        }

        public async Task<PromotionUpdateDTO> GetPromotionForUpdate(int id)
        {
            return await httpService.GetHelper<PromotionUpdateDTO>($"{url}/update/{id}");
        }

        public async Task<List<Promotion>> GetPromotionsByName(string name)
        {
            var response = await httpService.Get<List<Promotion>>($"{url}/search/{name}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Promotion> GetPromotionById(int id)
        {
            return await httpService.GetHelper<Promotion>($"{url}/{id}");
        }

        public async Task CreatePromotion(Promotion promotion)
        {
            var response = await httpService.Post(url, promotion);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdatePromotion(Promotion promotion)
        {
            var response = await httpService.Put(url, promotion);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeletePromotion(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}