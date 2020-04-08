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
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
    public class GiftsController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFileStorageService fileStorageService;
        private readonly IMapper mapper;
        private readonly UserManager<IdentityUser> userManager;

        public GiftsController(ApplicationDbContext context,
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
        [AllowAnonymous]
        public async Task<ActionResult<List<Gift>>> Get([FromQuery] PaginationDTO paginationDTO)
        {
            var currentUser = await userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var queryable = context.Gifts.Where(x => x.OwnerId == currentUser.PhoneNumber).AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordsPerPage);
            return await queryable.Paginate(paginationDTO).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Gift>> Get(int id)
        {
            var gift = await context.Gifts.FirstOrDefaultAsync(x => x.Id == id);
            if (gift == null) { return NotFound(); }
            return gift;
        }

        [HttpGet("search/{searchText}")]
        public async Task<ActionResult<List<Gift>>> FilterByName(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText)) { return new List<Gift>(); }
            return await context.Gifts.Where(x => x.Name.Contains(searchText))
                .Take(5)
                .ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Gift gift)
        {
            if (!string.IsNullOrWhiteSpace(gift.Picture))
            {
                var giftPicture = Convert.FromBase64String(gift.Picture);
                gift.Picture = await fileStorageService.SaveFile(giftPicture, "jpg", "gifts");
            }

            var userId = await userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            gift.OwnerId = userId.Id;

            context.Add(gift);
            await context.SaveChangesAsync();
            return gift.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Gift gift)
        {
            var giftDB = await context.Gifts.FirstOrDefaultAsync(x => x.Id == gift.Id);

            if (giftDB == null) { return NotFound(); }

            giftDB = mapper.Map(gift, giftDB);

            if (!string.IsNullOrWhiteSpace(gift.Picture))
            {
                var giftPicture = Convert.FromBase64String(gift.Picture);
                giftDB.Picture = await fileStorageService.EditFile(giftPicture,
                    "jpg", "gifts", giftDB.Picture);
            }

            await context.SaveChangesAsync();
            return NoContent();

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var gift = await context.Gifts.FirstOrDefaultAsync(x => x.Id == id);
            if (gift == null)
            {
                return NotFound();
            }

            context.Remove(gift);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
