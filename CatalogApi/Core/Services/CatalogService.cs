namespace CatalogApi.Core.Services;
public class CatalogService : ICatalogService
{

    public CatalogService(ICatalogRepository repository)
    {
        CatalogRepository = repository;
    }

    public ICatalogRepository CatalogRepository { get; }
}