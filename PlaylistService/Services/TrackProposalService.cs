using Playlist.Service.Shared;
using Playlist.Domain.Interfaces;
using Playlist.Domain.Input;
using Playlist.Domain;
using Microsoft.Extensions.ObjectPool;
using RabbitMQ.Client;
using Microsoft.Extensions.Logging;

namespace Playlist.Service
{
    public class TrackProposalService : RabbitManager<TrackProposal>, ITrackProposalService
    {
        private readonly ILogger<TrackProposalService> _logger;

        public TrackProposalService(IPooledObjectPolicy<IModel> objectPolicy, ILogger<TrackProposalService> logger) : base(objectPolicy)
        {
            _logger = logger;
        }

        public void Save(TrackProposalInput trackProposalInput)
        {
            TrackProposal trackProposal = new(trackProposalInput.Track)
            {
                User = trackProposalInput.User,
                Playlist = trackProposalInput.Playlist
            };

            try
            {
                Send(trackProposal, "playlist", "topic", "*.playlist.*");
            }
            catch (Exception ex)
            {
                _logger.LogError("Error sending message", ex);
                throw;
            }

            //TODO: persist to SQL Server Database

        }
    }
}