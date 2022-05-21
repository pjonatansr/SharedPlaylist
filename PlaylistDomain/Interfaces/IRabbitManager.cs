using Playlist.Domain.Input;

namespace Playlist.Domain.Interfaces
{
    public interface IRabbitManager<T> where T : class
    {
        void Send(T content, string exchange, string type, string routingKey);
    }
}