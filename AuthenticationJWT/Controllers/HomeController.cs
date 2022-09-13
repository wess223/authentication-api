using Microsoft.AspNetCore.Mvc;

namespace AuthenticationJWT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        public string Anonymous() => "Anônimo";

        public string Employee() => "Funcionário";

        public string Manager() => "Gerente";

        public string Authenticated() => "Authenticated";
    }
}