using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DockerTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DockerTest.Data
{
    public class CardContext : DbContext
    {
        public CardContext(DbContextOptions<CardContext> options)
            : base(options)
        {
        }

        public CardContext()
        {
        }

        public DbSet<CardsModel> Cards { get; set; }

        public static void SeedData(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider
                .GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope
                    .ServiceProvider.GetService<CardContext>();

                context.Database.EnsureCreated();

                if (context.Cards.Any()) return;

                context.Cards.AddRange(new CardsModel
                {
                    Name = "Ragnaros the Firelord",
                    ManaCost = 8,
                    Attack = 8,
                    Health = 8,
                    Rarity = "Legendary",
                    SetName = "Hall of Fame"
                }, new CardsModel
                {
                    Name = "Call of the Wild",
                    ManaCost = 9,
                    Attack = null,
                    Health = null,
                    Rarity = "Epic",
                    SetName = "Mean Streets of Gadgetzan"
                }, new CardsModel
                {
                    Name = "Corridor Creeper",
                    ManaCost = 7,
                    Attack = 2,
                    Health = 5,
                    Rarity = "Epic",
                    SetName = "Kobolds and Catacombs"
                });

                context.SaveChanges();
            }
        }
    }
}
