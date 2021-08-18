using System;
using CandyShop.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CandyShop.Infrastructure.Contexts
{
    public class CandyShopDbContext : DbContext
    {
        public CandyShopDbContext(DbContextOptions<CandyShopDbContext> options)
            : base(options) { }
        public DbSet<Sweetness> Sweetnesses{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Sweetness>()
                .Property(e => e.SweetnessCategory)
                .HasConversion(
                    v => v.ToString(),
                    v => (SweetnessCategory)Enum.Parse(typeof(SweetnessCategory), v));
        }
    }
}
