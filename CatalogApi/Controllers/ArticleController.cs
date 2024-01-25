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
        _logger = logger;
        _catalogService = catalogService;
    }

    // GET: api/v1/Article/cost
    [HttpGet]
    [Route("cost")]
    public decimal GetAllArticlesCost()
    {
        decimal res = 150.99m;

        return res;
    }

    // GET api/v1/Article/limitedArticles/5
    [HttpGet]
    [Route("limitedArticles/{stockCountLimit:int}")]
    public IEnumerable<Article> GetLimitedArticles(int stockCountLimit = 0)
    {
        return new Article[] {
                new() {
                    Id = 1,
                    Name = "Microsoft",
                    CategoryId = 1,
                    Stock = 10,
                    PriceBuy = 10.25m,
                    PriceSell = 10.99m

                },
                new() {
                    Id = 2,
                    CategoryId = 2,
                    Name = "HP",
                    Stock = 10,
                    PriceBuy = 10.25m,
                    PriceSell = 10.99m
                },
            };
    }

    // POST api/v1/Article/addNew
    [HttpPost]
    [Route("addNew")]
    public Article AddNewArticle([FromBody] Article model)
    {
        var res = new Article
        {
            Id = model.Id + 10,
        };

        return res;
    }

}
