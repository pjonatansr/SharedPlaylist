using System.Text.Json.Serialization;

namespace PlaylistDomain.Domain
{
    public sealed class Playlist
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Track> Tracks { get; set; }

        public Playlist(Guid id, string name, string description, ICollection<Track> tracks)
        {
            Id = id;
            Name = name;
            Description = description;
            Tracks = tracks;
        }

        [JsonConstructor]
        public Playlist(string name, ICollection<Track> tracks)
        {
            Name = name;
            Tracks = tracks;
        }
    }
}
