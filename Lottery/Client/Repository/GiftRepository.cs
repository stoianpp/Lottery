using Lottery.Client.Helpers;
using Lottery.Shared.DTOs;
using Lottery.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lottery.Client.Repository
{
    public class GiftRepository : IGiftRepository
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/gifts";

        public GiftRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<PaginatedResponse<List<Gift>>> GetGifts(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<Gift>>(url, paginationDTO);
        }

        public async Task<List<Gift>> GetAll()
        {
            var response = await httpService.Get<List<Gift>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<List<Gift>> GetGiftsByPromotion(Promotion promotion)
        {
            var response =  await httpService.Get<List<Gift>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<List<Gift>> GetGiftsByName(string name)
        {
            var response = await httpService.Get<List<Gift>>($"{url}/search/{name}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Gift> GetGiftById(int id)
        {
            return await httpService.GetHelper<Gift>($"{url}/{id}");
        }

        public async Task CreateGift(Gift gift)
        {
            var response = await httpService.Post(url, gift);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateGift(Gift gift)
        {
            var response = await httpService.Put(url, gift);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteGift(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
