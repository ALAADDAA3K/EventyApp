using EventyApp.Models;

namespace EventyApp.Service.Interface
{
    public interface ITokenService
    {
        string GenerateToken(Users users);

    }
}
