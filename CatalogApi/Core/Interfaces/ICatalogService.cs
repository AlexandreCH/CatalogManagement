namespace CatalogApi.Core.Interfaces;
public interface ICatalogService
{
    Task<decimal> GetTotalArticleCostAsync();
    Task<Category[]> GetCategoriesWithFullInfoAsync();
    Task<Article[]> GetAllArticlesUnderStockLimitAsync(uint stockLimt);
    Task<Article> AddNewArticleAsync(Article articleToAdd);


}