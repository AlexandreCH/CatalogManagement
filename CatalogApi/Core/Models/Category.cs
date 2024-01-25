using System.ComponentModel.DataAnnotations;

namespace CatalogApi.Core.Models;
public class Category
{
    public int Id { get; set; }

    /// <summary>
    /// Parent category Id
    /// </summary>
    public int? CategoryId { get; set; } = null;

    [Required]
    public string Name { get; set; } = string.Empty;


}
