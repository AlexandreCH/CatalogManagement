// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using CatalogApi.Core.Models;
using CatalogApi.Core.Services;

namespace CatalogApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ICatalogService _catalogService;

        public CategoryController(ICatalogService catalogService, ILogger<CategoryController> logger)
        {
            _logger = logger;
            _catalogService = catalogService;
        }

        // GET: api/v1/Category/cagegoryInfo
        [HttpGet]
        [Route("categoryInfo")]
        public IEnumerable<Category> CategoryInfo()
        {
            return new Category[] {
                new() {
                    Id = 1,
                    Name = "Microsoft"
                },
                new() {
                    Id = 2,
                    CategoryId = 1,
                    Name = "HP"
                },
            };
        }
    }
}
