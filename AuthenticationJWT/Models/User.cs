using System.ComponentModel.DataAnnotations;

namespace AuthenticationJWT.Models
{
    public class User
    {
        public int Id { get; set; }

        [StringLength(20), Required(ErrorMessage = "Campo obrigatório.")]
        public string Username { get; set; }

        [StringLength(20), Required(ErrorMessage = "Campo obrigatório.")]
        public string Password { get; set; }

        public string Role { get; set; }
    }
}
