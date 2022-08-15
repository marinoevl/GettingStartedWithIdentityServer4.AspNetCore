using IdentityModel.Client;

namespace WebApplication1.Services
{
    public interface ITokenService
    {
        Task<TokenResponse> GetToken(string scope);
    }
}
