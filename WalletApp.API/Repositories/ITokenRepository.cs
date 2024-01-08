using WalletApp.API.Models.Domain;

namespace WalletApp.API.Repositories;

public interface ITokenRepository
{
    string CreateJwtToken(ApplicationUser user);
}