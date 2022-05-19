namespace PlaylistApi.Interfaces
{
    public interface IRepository<T> where T : class
    {
        // add save
        void Add(T target);
    }
}
