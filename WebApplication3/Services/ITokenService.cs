using IdentityModel.Client;

namespace WebApplication3.Services
{
    public interface ITokenService
    {
        Task<TokenResponse> GetToken(string scope);
    }
}
