using Microsoft.AspNetCore.Mvc;
using SunOut_ERP_Backend.Domain;

namespace SunOut_ERP_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        // GET: api/user/login
        [HttpPost("login")]
        public ActionResult Login(User u)
        {
            // hashear pw
            // llamado dataAccess
            return Unauthorized();
        }
    }
}
