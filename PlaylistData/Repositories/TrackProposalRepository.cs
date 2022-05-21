using Playlist.Domain.Interfaces;
using Playlist.Data.Context;
using Playlist.Domain;

namespace Playlist.Data.Repositories
{
    public class TrackProposalRepository : IRepository<TrackProposal>
    {
        private readonly DataContext _context;

        public TrackProposalRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(TrackProposal item)
        {
            _context.TrackProposals.Add(item);
        }

    }
}
