// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CatalogApi.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ILogger<CategoryController> _logger;
    private readonly ICatalogService _catalogService;

    public CategoryController(ICatalogService catalogService, ILogger<CategoryController> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _catalogService = catalogService ?? throw new ArgumentNullException(nameof(catalogService));
    }

    // GET: api/v1/Category/cagegoryInfo
    [HttpGet]
    [Route("categoryInfo")]
    public async Task<IEnumerable<Category>> CategoryInfo() => await _catalogService.GetCategoriesWithFullInfoAsync();
}
