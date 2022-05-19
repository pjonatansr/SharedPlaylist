using PlaylistDomain.Domain.Input;

namespace PlaylistApi.Interfaces
{
    public interface IRabbitManager<T> where T : class
    {
        void Send(T target);
        
    }
}