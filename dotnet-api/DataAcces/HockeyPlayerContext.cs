using dotnet_api.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace dotnet_api.DataAcces
{
    public class HockeyPlayerContext : DbContext
    {
        public HockeyPlayerContext(DbContextOptions options) : base(options)
        {
        }
       public virtual DbSet<HockeyPlayer> HockeyPlayers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
