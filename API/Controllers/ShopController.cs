using System.Threading.Tasks;
using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [ApiController]
  [Route("")]
  public class ShopController : ControllerBase
  {
    private readonly StoreContext _context;
    public ShopController(StoreContext context)
    {
      _context = context;
    }

    [HttpGet("shop")]
    public string ReturnString()
    {
      return "shop";
    }
    public static string Test { get; set; } = "test";
  }
}