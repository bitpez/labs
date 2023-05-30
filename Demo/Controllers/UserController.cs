using Microsoft.AspNetCore.Mvc;
using net60_react.Models;

namespace net60_react.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly CodeDemoContext _DBContext;

    public UserController(CodeDemoContext dbContext)
    {
       this._DBContext = dbContext;
    }

    [HttpGet()]
    public bool Get(string user, string pass)
    {
        var products = this._DBContext.Users.Where(a=>a.User1.Equals(user) && a.Firm.Equals(pass)).ToList();

        return products.Count > 0;
    }
}
