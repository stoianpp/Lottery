using AutoMapper;
using Lottery.Server.Helpers;
using Lottery.Shared.DTOs;
using Lottery.Shared.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lottery.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class PromotionsController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFileStorageService fileStorageService;
        private readonly IMapper mapper;
        private readonly UserManager<IdentityUser> userManager;

        public PromotionsController(ApplicationDbContext context,
            IFileStorageService fileStorageService,
            IMapper mapper,
            UserManager<IdentityUser> userManager)
        {
            this.context = context;
            this.fileStorageService = fileStorageService;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<List<Promotion>>> Get([FromQuery] PaginationDTO paginationDTO)
        {
            var currentUser = await userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var queryable = context.Promotions.Where(x => x.OwnerId == currentUser.PhoneNumber).AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordsPerPage);
            return await queryable.Paginate(paginationDTO).ToListAsync();
        }

        [HttpGet("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        public async Task<ActionResult<Promotion>> Get(int id)
        {
            var promotion = await context.Promotions.Where(x => x.Id == id)
                .Include(x => x.GiftsPromotions)
                .FirstOrDefaultAsync();

            if (promotion == null) { return NotFound(); }

            promotion.GiftsPromotions = promotion.GiftsPromotions.OrderBy(x => x.Order).ToList();
            return promotion;
        }

        [HttpGet("search/{searchText}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        public async Task<ActionResult<List<Promotion>>> FilterByName(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText)) { return new List<Promotion>(); }
            return await context.Promotions.Where(x => x.Name.Contains(searchText))
                .Take(5)
                .ToListAsync();
        }

        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        public async Task<ActionResult<int>> Post(Promotion promotion)
        {
            var userId = await userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            promotion.OwnerId = userId.Id;

            if (promotion.GiftsPromotions != null)
            {
                for (int i = 0; i < promotion.GiftsPromotions.Count; i++)
                {
                    promotion.GiftsPromotions[i].Order = i + 1;
                }
            }

            context.Add(promotion);
            await context.SaveChangesAsync();
            return promotion.Id;
        }

        [HttpPut]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        public async Task<ActionResult> Put(Promotion promotion)
        {
            var promotionDB = await context.Promotions.FirstOrDefaultAsync(x => x.Id == promotion.Id);

            if (promotionDB == null) { return NotFound(); }

            promotionDB.Name = promotion.Name;
            promotionDB.Description = promotion.Description;
            promotionDB.Active = promotion.Active;

            await context.Database.ExecuteSqlInterpolatedAsync($"delete from Giftspromotions where PromotionId = {promotion.Id};");

            if (promotion.GiftsPromotions != null)
            {
                for (int i = 0; i < promotion.GiftsPromotions.Count; i++)
                {
                    promotion.GiftsPromotions[i].Order = i + 1;
                }
            }

            promotionDB.GiftsPromotions = promotion.GiftsPromotions;

            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet("update/{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

        public async Task<ActionResult<PromotionUpdateDTO>> PutGet(int id)
        {
            var promotionActionResult = await Get(id);
            if (promotionActionResult.Result is NotFoundResult) { return NotFound(); }

            var promotionDetailDTO = promotionActionResult.Value;

            var currentUser = await userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var giftsCurrentUsers = await context.Gifts
                .Where(x => x.OwnerId == currentUser.PhoneNumber)
                .ToListAsync();

            var selectedGiftsIds = promotionDetailDTO.GiftsPromotions.Select(x => x.GiftId).ToList();
            var notSelectedGifts = giftsCurrentUsers
                .Where(x => !selectedGiftsIds.Contains(x.Id)).ToList();
            var selectedGifts = giftsCurrentUsers
               .Where(x => selectedGiftsIds.Contains(x.Id)).ToList();

            var model = new PromotionUpdateDTO();
            model.Promotion = promotionDetailDTO;
            model.SelectedGifts = selectedGifts;
            model.NotSelectedGifts = notSelectedGifts;
            return model;
        }

        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        public async Task<ActionResult> Delete(int id)
        {
            var promotion = await context.Promotions.FirstOrDefaultAsync(x => x.Id == id);
            if (promotion == null)
            {
                return NotFound();
            }

            var giftpromotions = context.GiftsPromotions.Where(x => x.PromotionId == id);
            context.RemoveRange(giftpromotions);
            context.Remove(promotion);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
