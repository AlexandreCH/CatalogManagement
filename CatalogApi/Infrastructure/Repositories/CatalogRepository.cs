namespace CatalogApi.Infrastructure.Repositories;

// TODO: Add EF to be handled by Repository

public class CatalogRepository : ICatalogRepository
{
    public async Task<Article> AddNewArticleAsync(Article articleToAdd)
    {
        return await Task.Run(() => {
            return new Article()
            {
                Id = articleToAdd.Id + 10,
                CategoryId = articleToAdd.CategoryId,
                Name = articleToAdd.Name,
                Stock = articleToAdd.Stock,
                PriceBuy = articleToAdd.PriceBuy,
                PriceSell = articleToAdd.PriceSell
            };
        });
    }

    public async Task<Article[]> GetAllArticlesAsync()
    {
        return await Task.Run(() => {
            return new[]
            {
                new Article { Id = 1, CategoryId = 3, Name = "Samsung Galaxy S20", Stock = 10, PriceBuy = 600.0m, PriceSell = 800.0m },
                new Article { Id = 2, CategoryId = 3, Name = "Xiaomi", Stock = 10, PriceBuy = 250.0m, PriceSell = 299.99m},
                new Article {Id = 3, CategoryId = 4, Name = "iPhone 14", Stock = 8, PriceBuy = 900.0m, PriceSell = 1200.0m},
                new Article {Id = 4, CategoryId = 5, Name = "Pc Gamer", Stock = 2, PriceBuy = 1800.0m, PriceSell = 2000.0m},
                new Article {Id = 5, CategoryId = 6, Name = "Kindle", Stock = 0, PriceBuy = 150.0m, PriceSell = 180.0m},
                new Article {Id = 6, CategoryId = 7, Name = "Lenovo 27 pouces", Stock = 3, PriceBuy = 250.0m, PriceSell = 330.0m},
                new Article {Id = 7, CategoryId = 8, Name = "Samsung The Frame", Stock = 10, PriceBuy = 1400.0m, PriceSell = 1500.0m},
                new Article {Id = 8, CategoryId = 10, Name = "Frigo Electrolux", Stock = 5, PriceBuy = 800.0m, PriceSell = 1000.0m},
                new Article {Id = 9, CategoryId = 11, Name = "Whirlpool", Stock = 5, PriceBuy = 450.0m, PriceSell = 550.0m},
            };
        });
    }
    public async Task<Category[]> GetAllCategoriesAsync()
    {
        return await Task.Run(() => {
            return new[]
            {
                new Category { Id = 1, CategoryId = null, Name = "High Tech"},
                new Category { Id = 2, CategoryId = 1, Name = "Téléphonie"},
                new Category { Id = 3, CategoryId = 2, Name = "Android"},
                new Category { Id = 4, CategoryId = 2, Name = "iOS" },
                new Category { Id = 5, CategoryId = 1, Name = "PC" },
                new Category { Id = 6, CategoryId = 1, Name = "Ecrans" },
                new Category { Id = 7, CategoryId = 6, Name = "Ecran PC" },
                new Category { Id = 8, CategoryId = 6, Name = "Ecran TV" },
                new Category { Id = 9, CategoryId = null, Name = "Electroménager" },
                new Category { Id = 10, CategoryId = 9, Name = "Frigo" },
                new Category { Id = 11, CategoryId = 9, Name = "Lave vaisselle" }
            };
        });
    }
}
