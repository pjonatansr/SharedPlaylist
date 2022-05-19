using PlaylistDomain.Domain;
using PlaylistDomain.Domain.Input;

namespace PlaylistApi.Interfaces
{
    public interface ITrackProposalService : IRabbitManager<TrackProposal>
    {
        void Save(TrackProposalInput trackProposal);
    }
}