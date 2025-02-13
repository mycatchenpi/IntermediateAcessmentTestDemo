using YourProject.Domain.Entities;
using YourProject.Domain.Services;

namespace YourProject.Domain
{
    public class Authenticator : IAuthenticator
    {
        public bool Authenticate(User user)
        {
            return user.Username == "admin" && user.Password == "admin";
        }
    }
}
