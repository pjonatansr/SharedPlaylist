using System.Text.Json.Serialization;

namespace PlaylistDomain.Domain
{
    public sealed class Track
    { 
        public string Name { get; }
        public string? Artist { get; }
        public string? Album { get; }
        public string? Genre { get; }
        public string Link { get; }

        [JsonConstructor]
        public Track(string name, string link)
        {
            Name = name;
            Link = link;
        }

        public Track(string name, string artist, string album, string genre, string link)
        {
            Name = name;
            Artist = artist;
            Album = album;
            Genre = genre;
            Link = link;
        }
    }
}
