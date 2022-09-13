using AuthenticationJWT.Models;
using AuthenticationJWT.Repositories;
using AuthenticationJWT.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost]
        [Route("authenticate")]
        [AllowAnonymous]
        public ActionResult<object> Authenticate([FromBody]User model)
        {
            if (!ModelState.IsValid) return BadRequest();

            var user = UserRepository.Get(model.Username, model.Password); //buscar usuário na base de dados.
            if (user == null)
                return NotFound(new { message = "usuário não encontrado." }); //verifica se o usuário existe.

            user.Password = ""; //ocultar o password.
            var token = TokenServices.GenerateToken(user); //gerar token com base no user.

            return new { user, token }; //Retorna dados
        }
    }
}
