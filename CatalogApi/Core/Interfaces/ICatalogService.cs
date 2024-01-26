namespace CatalogApi.Core.Interfaces;
public interface ICatalogService
{
    Task<decimal> GetTotalArticleCostAsync();
    Task<Category[]> GetCategoriesWithFullInfoAsync();
    Task<Article[]> GetAllArticlesUnderStockLimitAsync(int stockLimt);
    Task<Article> AddNewArticleAsync(Article articleToAdd);


}