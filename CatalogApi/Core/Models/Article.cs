namespace CatalogApi.Core.Models;
public class Article
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public int Stock { get; set; }

    public decimal PriceBuy { get; set; }

    public decimal PriceSell { get; set; }
}
