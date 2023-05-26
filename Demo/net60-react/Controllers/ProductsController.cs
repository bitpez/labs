using Microsoft.AspNetCore.Mvc;

namespace net60_react.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Coca-Cola", "7-up"
    };

    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Product> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Product
        {
            Name = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
