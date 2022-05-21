using Microsoft.Extensions.ObjectPool;
using Playlist.Domain;
using Playlist.Domain.Interfaces;
using RabbitMQ.Client;
using System.Text;

namespace Playlist.Service.Shared
{
    public class RabbitManager<T> : IRabbitManager<T> where T : RabbitMessage
    {
        private readonly DefaultObjectPool<IModel> _objectPool;

        public RabbitManager(IPooledObjectPolicy<IModel> objectPolicy)
        {
            _objectPool = new DefaultObjectPool<IModel>
                (objectPolicy, Environment.ProcessorCount * 2);
        }

        public void Send(T content, string exchange, string type, string routeKey)
        {
            if (content == null)
                return;

            var channel = _objectPool.Get();

            try
            {
                bool durable = true;
                channel.ExchangeDeclare(exchange, type, true, durable);

                var body = Encoding.UTF8.GetBytes(content.GetMessage());

                var properties = channel.CreateBasicProperties();
                properties.Persistent = true;

                channel.BasicPublish(exchange, routeKey, properties, body);
            }
            catch
            {
                throw;
            }
            finally
            {
                _objectPool.Return(channel);
            }
        }
    }
}
