using Lottery.Shared.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lottery.Server
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<GiftsPromotions>().HasKey(x => new { x.GiftId, x.PromotionId });

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Gift> Gifts { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<GiftsPromotions> GiftsPromotions { get; set; }
    }
}
