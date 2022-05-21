namespace Playlist.Domain
{
    public sealed class TrackProposal : RabbitMessage
    {
        public Guid? Id { get; set; }
        public Track Track { get; set; }
        public User? User { get; set; }

        public Playlist? Playlist { get; set; }

        public TrackProposal(Track track)
        {
            Track = track;
        }

        public override string GetMessage()
        {
            return System.Text.Json.JsonSerializer.Serialize(this);
        }
    }
}
