using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers
{
    [Route("api/identity")]
    [ApiController]
    [Authorize]
    public class IdentityController : ControllerBase
    {
        public IdentityController()
        {

        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var claims = User.Claims.Select(x => new { x.Type, x.Value });
            return await Task.FromResult(Ok(claims));
        }
    }
}
