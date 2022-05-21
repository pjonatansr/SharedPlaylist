using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Playlist.Domain;

namespace Playlist.Data.Context
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DbSet<TrackProposal> TrackProposals { get; set; }

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }

    }
}