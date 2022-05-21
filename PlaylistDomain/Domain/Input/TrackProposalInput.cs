using System.Text.Json.Serialization;

namespace Playlist.Domain.Input
{
    public sealed class TrackProposalInput
    {
        public Track Track { get; set; }
        public Playlist? Playlist { get; set; }

        public User? User { get; set; }

        [JsonConstructor]
        public TrackProposalInput(Track track, Playlist? playlist, User? user) : this(track)
        {
            Playlist = playlist;
            User = user;
        }

        public TrackProposalInput(Track track)
        {
            Track = track;
        }
    }
}