using Microsoft.AspNetCore.Mvc;

namespace test_api_gateway.Controllers
{
    [ApiController]
    [Route("api/")]
    public class GatewayController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllPersons()
        {
            
            return Ok("Всё работает!");
        }
    }
}
