namespace PletkaRedka.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using PletkaRedka.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            var categories = new List<string>
            {
                "Видове плетки",
                "Видео уроци",
                "Схеми",
                "Цветя",
                "Плетени бижута",
                "Плетени играчки",
                "Плетива с мъниста",
            };

            foreach (var item in categories)
            {
                await dbContext.AddAsync(new Category
                {
                    Name = item,
                    Description = item,
                });
            }
        }
    }
}
