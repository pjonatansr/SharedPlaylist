using PlaylistApi.Interfaces;

namespace PlaylistDomain.Services.Shared
{
    public class RabbitManager<T> : IRabbitManager<T> where T : class
    {
        public void Send(T message)
        {
           
            //publish it in the rabbit queue 

        }
    }
}
