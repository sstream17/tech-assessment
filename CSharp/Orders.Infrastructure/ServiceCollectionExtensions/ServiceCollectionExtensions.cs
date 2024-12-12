using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Orders.Infrastructure.EntityFramework;

namespace Orders.Infrastructure.ServiceCollectionExtensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructureDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddTransient<IOrdersAccessor, OrdersAccessor>();

            services.AddTransient<IOrdersDbContext, OrdersDbContext>();
            var connectionString = configuration.GetConnectionString("Orders");
            services.AddDbContext<OrdersDbContext>(
                options => options.UseLazyLoadingProxies()
                    .UseSqlServer(connectionString));
        }
    }
}
