// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CatalogApi.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class ArticleController : ControllerBase
{
    private readonly ILogger<ArticleController> _logger;
    private readonly ICatalogService _catalogService;

    public ArticleController(ICatalogService catalogService, ILogger<ArticleController> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _catalogService = catalogService ?? throw new ArgumentNullException(nameof(catalogService));
    }

    // GET: api/v1/Article/cost
    [HttpGet]
    [Route("cost")]
    public async Task<decimal> GetAllArticlesCost() => 
        await _catalogService.GetTotalArticleCostAsync();

    // GET api/v1/Article/limitedArticles/5
    [HttpGet]
    [Route("limitedArticles/{stockCountLimit:int}")]
    public async Task<IEnumerable<Article>> GetLimitedArticles(uint stockCountLimit = 0) => 
        await _catalogService.GetAllArticlesUnderStockLimitAsync(stockCountLimit);
    
    // POST api/v1/Article/addNew
    [HttpPost]
    [Route("addNew")]
    public async Task<Article> AddNewArticle([FromBody] Article model) => 
        await _catalogService.AddNewArticleAsync(model);

}
