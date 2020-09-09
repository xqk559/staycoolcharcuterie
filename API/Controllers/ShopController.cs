using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

    [HttpGet("products")]
    public async Task<ActionResult<List<Product>>> GetProducts()
    {
        var products = await _context.Products.ToListAsync();

        return Ok(products);
    }
  }
}