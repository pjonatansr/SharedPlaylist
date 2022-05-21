using Microsoft.Extensions.ObjectPool;
using Playlist.Domain.Configuration;
using Playlist.Service.RabbitMQ;
using RabbitMQ.Client;

namespace Playlist.Api.Extensions
{
    public static class RabbitServiceCollectionExtensions
    {
        public static IServiceCollection AddRabbit(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<RabbitOptions>(configuration.GetSection(RabbitOptions.Rabbit));
            services.AddSingleton<ObjectPoolProvider, DefaultObjectPoolProvider>();
            services.AddSingleton<IPooledObjectPolicy<IModel>, RabbitModelPooledObjectPolicy>();

            return services;
        }
    }
}
