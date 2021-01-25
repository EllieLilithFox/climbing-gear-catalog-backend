using Microsoft.EntityFrameworkCore;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.Extensions.Options;
using ClimbingGearBackend.Models;

namespace ClimbingGearBackend.Infrastucture
{
  public class ClimbingGearContext : ApiAuthorizationDbContext<User>
  {
    public ClimbingGearContext(
      DbContextOptions<ClimbingGearContext> options,
      IOptions<OperationalStoreOptions> operationalStoreOptions)
      : base(options, operationalStoreOptions)
    {
    }

    public DbSet<Gear> Gear { get; set; }
    public DbSet<UserGear> UserGear { get; set; }
  }
}