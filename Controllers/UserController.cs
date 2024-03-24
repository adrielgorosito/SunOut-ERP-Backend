using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SunOut_ERP_Backend.DataAccess.UnitOfWork;
using SunOut_ERP_Backend.Domain;

namespace SunOut_ERP_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork Uow;
        private readonly PasswordHasher<User> _passwordHasher;

        public UserController(IUnitOfWork uow)
        {
            Uow = uow;
            _passwordHasher = new PasswordHasher<User>();
        }

        // POST: api/user/login
        [HttpPost("login")]
        public async Task<ActionResult> Login(User u)
        {
            User? user = await Uow.UserRepository.GetOneByUsername(u.Username);

            if (user != null)
            {
                var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, u.PasswordHash);

                if (result == PasswordVerificationResult.Success)
                {
                    return Ok(user);
                }
            }
            return Unauthorized("Invalid credentials");
        }
    }
}