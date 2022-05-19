using System.Text.Json.Serialization;

namespace PlaylistDomain.Domain
{
    public sealed class User
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }

        [JsonConstructor]        
        public User(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
