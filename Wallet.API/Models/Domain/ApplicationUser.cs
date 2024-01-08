using Microsoft.AspNetCore.Identity;

namespace Wallet.API.Models.Domain;

public class ApplicationUser: IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ICollection<Wallet> Wallets { get; set; }
}