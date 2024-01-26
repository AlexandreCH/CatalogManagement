
namespace CatalogApi.Core.Interfaces;
public interface ICatalogRepository
{
    Task<Article> AddNewArticleAsync(Article articleToAdd);
    Task<Article[]> GetAllArticlesAsync();
    Task<Category[]> GetAllCategoriesAsync();
}