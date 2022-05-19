namespace PlaylistDomain.Domain
{
    public sealed class TrackProposal
    {
        public Guid? Id { get; set; }
        public Track Track { get; set; }
        public User? User { get; set; }

        public Playlist? Playlist { get; set; }

        public TrackProposal(Track track)
        {
            Track = track;
        }

    }
}
