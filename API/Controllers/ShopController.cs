using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("")]
    public class ShopController : ControllerBase
    {
        [HttpGet("shop")]
        public string ReturnString()
        {
            return "shop";
        }
        public static string Test { get; set; } = "test";
    }
}