namespace CatalogApi.Core.Models;
public class Article
{
    [Required]
    public int Id { get; set; }

    [Required]
    public int CategoryId { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;
    [Range(0, int.MaxValue)]
    public int Stock { get; set; }

    [Range((double)0m, (double)decimal.MaxValue)]
    public decimal PriceBuy { get; set; }

    // TODO: Add custom attribute to validate Buy-Sell price rule
    [Range((double)0m, (double)decimal.MaxValue)]
    public decimal PriceSell { get; set; }
}
