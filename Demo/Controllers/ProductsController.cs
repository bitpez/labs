using Microsoft.AspNetCore.Mvc;
using net60_react.Models;

namespace net60_react.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly CodeDemoContext _DBContext;

    public ProductsController(CodeDemoContext dbContext)
    {
       this._DBContext = dbContext;
    }

    [HttpGet]
    public IEnumerable<net60_react.Models.Product> Get()
    {
        var products = this._DBContext.Products.ToList();

        return products;
    }
}
