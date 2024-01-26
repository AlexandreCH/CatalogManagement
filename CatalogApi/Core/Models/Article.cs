namespace CatalogApi.Core.Models;
public class Article
{
    [Required]
    public int Id { get; set; }

    [Required]
    public int CategoryId { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [Range(0, int.MaxValue)]
    public int Stock { get; set; }

    [Range((double)0m, (double)decimal.MaxValue)]
    public decimal PriceBuy { get; set; }

    [Range((double)0m, (double)decimal.MaxValue)]
    [ValidatePrice]
    public decimal PriceSell { get; set; }
}
