using Microsoft.EntityFrameworkCore;
using Wallet.API.Models.Domain;

namespace Wallet.API.Data;

public class WalletDbContext : DbContext
{

    public WalletDbContext(DbContextOptions<WalletDbContext> dbContextOptions) : base(dbContextOptions)
    {

    }

    public DbSet<Models.Domain.Wallet> Wallets { get; set; }
    public DbSet<ApplicationUser> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Models.Domain.Wallet>()
            .HasOne(w => w.Owner)
            .WithMany(u => u.Wallets)
            .HasForeignKey(w => w.OwnerId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
