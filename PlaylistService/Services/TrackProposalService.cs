using PlaylistDomain.Domain;
using PlaylistDomain.Domain.Input;
using PlaylistDomain.Services.Shared;
using PlaylistApi.Interfaces;

namespace PlaylistDomain.Services
{
    public class TrackProposalService : RabbitManager<TrackProposal>, ITrackProposalService
    {
        public void Save(TrackProposalInput trackProposalInput)
        {
            TrackProposal trackProposal = new(trackProposalInput.Track)
            {
                User = trackProposalInput.User,
                Playlist = trackProposalInput.Playlist
            };

            //TODO: save to db sql server
            Send(trackProposal);
        }
    }
}