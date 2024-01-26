using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CatalogApi.Core.Models;
public class Category
{
    [Required]
    public int Id { get; set; }

    /// <summary>
    /// Parent category Id
    /// </summary>
    public int? CategoryId { get; set; } = null;

    [Required]
    public string Name { get; set; } = string.Empty;

    //[JsonIgnore]
    public List<Category> SubCategories { get; set;} = new List<Category>();

    //[JsonIgnore]
    public List<Article> Articles { get; set; } = new List<Article>();
}
