using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationJWT.Controllers
{
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("autheticated")]
        [Authorize]
        public string Authenticated() => $"Autenticado - {User.Identity.Name}.";

        [HttpGet]
        [Route("employee")]
        [Authorize(Roles = "manager, employee")]
        public string Employee() => "Funcionário";

        [HttpGet]
        [Route("manager")]
        [Authorize(Roles = "manager")]
        public string Manager() => "Gerente";
    }
}