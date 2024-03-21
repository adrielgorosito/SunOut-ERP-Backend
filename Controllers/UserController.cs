using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SunOut_ERP_Backend.Domain;

namespace SunOut_ERP_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly PasswordHasher<User> _passwordHasher;

        public UserController()
        {
            _passwordHasher = new PasswordHasher<User>();
        }

        // GET: api/user/login
        [HttpPost("login")]
        public ActionResult Login(User u)
        {

            // get user from db: var user = GetUser(u.Username)

            //if (user != null)
            //{
            //    var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, u.PasswordHash);

            //    if (result == PasswordVerificationResult.Success)
            //    {
            //        // Success
            //        // ...
            //        return Ok("....");
            //    }
            //}

            return Unauthorized("Invalid credentials");
        }
    }
}
