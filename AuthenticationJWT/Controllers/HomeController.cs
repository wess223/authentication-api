using Microsoft.AspNetCore.Mvc;

namespace AuthenticationJWT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        public string Anonymous() => "An�nimo";

        public string Employee() => "Funcion�rio";

        public string Manager() => "Gerente";

        public string Authenticated() => "Authenticated";
    }
}