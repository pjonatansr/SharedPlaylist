namespace Playlist.Domain.Configuration
{
    public class RabbitOptions
    {
        public const string Rabbit = "Rabbit";
        public string UserName { get; set; } = String.Empty;

        public string Password { get; set; } = String.Empty;

        public string HostName { get; set; } = String.Empty;

        public int Port { get; set; } = 5672;

        public string VHost { get; set; } = "/";
    }

}
