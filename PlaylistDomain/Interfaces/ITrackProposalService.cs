using Playlist.Domain.Input;

namespace Playlist.Domain.Interfaces
{
    public interface ITrackProposalService : IRabbitManager<TrackProposal>
    {
        void Save(TrackProposalInput trackProposal);
    }
}