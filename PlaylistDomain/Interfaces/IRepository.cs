namespace Playlist.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T target);
    }
}
