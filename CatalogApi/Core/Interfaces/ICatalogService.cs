namespace CatalogApi.Core.Interfaces;
public interface ICatalogService
{
    ICatalogRepository CatalogRepository { get; }

}