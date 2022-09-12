using AuthenticationJWT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost]
        [Route("signIn")]
        public IActionResult SignIn(Authenticate authenticate)
        {
            if (!ModelState.IsValid) return BadRequest();
            else return Ok(authenticate);
        }

        [HttpPost]
        [Route("signOut")]
        public IActionResult SignOut(Authenticate authenticate)
        {
            if (!ModelState.IsValid) return BadRequest();
            else return Ok("deslogado.");
        }
    }
}
