using AuthenticationJWT.Models;

namespace AuthenticationJWT.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            List<User> userList = new List<User>
            {
                new () { Id= 1, Username="wesley", Password="wesley", Role="manager" },
                new () { Id= 2, Username="paulo", Password="paulo", Role = "employee" }
            };

            return userList.FirstOrDefault(x => x.Username == username.ToLower() && x.Password == password.ToLower());
        }
    }
}
