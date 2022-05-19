using PlaylistApi.Interfaces;
using PlaylistData.Context;
using PlaylistDomain.Domain;

namespace PlaylistData.Repositories
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
