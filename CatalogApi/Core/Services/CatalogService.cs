using Microsoft.Extensions.Logging;
using System.Diagnostics.Eventing.Reader;

namespace CatalogApi.Core.Services;
public class CatalogService : ICatalogService
{
    private readonly ICatalogRepository _catalogRepository;

    public CatalogService(ICatalogRepository repository)
    {
        _catalogRepository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public async Task<Category[]> GetCategoriesWithFullInfoAsync()
    {
        var categories = await _catalogRepository.GetAllCategoriesAsync();

        if (categories is null || categories.Length == 0)
            return new Category[0];

        var articles = await _catalogRepository.GetAllArticlesAsync();

        // Lookup for children
        var lookup = categories.ToLookup(c => c.CategoryId);

        // Loop through the items and associate each item with the subitems using the lookup
        foreach (var category in categories)
        {
            category.SubCategories = lookup[category.Id].ToList();
            if (articles is not null && articles.Length > 0)
                category.Articles = articles.Where(a => a.CategoryId == category.Id).ToList();
        }

        // Get all root Categories
#if DEBUG_
        var rootCategories = lookup[null].ToArray();
        return rootCategories;
#else
        return lookup[null].ToArray();
#endif
    }

    public async Task<decimal> GetTotalArticleCostAsync()
    {
        var articles = await _catalogRepository.GetAllArticlesAsync();

        return articles.Select(a => a.PriceBuy * a.Stock).Sum();
    }

    public async Task<Article[]> GetAllArticlesUnderStockLimitAsync(uint stockLimt)
    {
        var articles = await _catalogRepository.GetAllArticlesAsync();

        if (articles is null || articles.Length == 0)
            return new Article[0];

        return articles.Where(a => a.Stock <= stockLimt).ToArray();
    }
    public async Task<Article> AddNewArticleAsync(Article articleToAdd)
    {
        return await _catalogRepository.AddNewArticleAsync(articleToAdd);
    }

}