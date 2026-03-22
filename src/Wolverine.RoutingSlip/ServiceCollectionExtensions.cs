using Wolverine.RoutingSlip.Abstractions.Contexts;
using Wolverine.RoutingSlip.Middlewares;

namespace Wolverine.RoutingSlip;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRoutingSlipCore(this IServiceCollection services)
    {
        services.AddSingleton<IRoutingSlipStore, InMemoryRoutingSlipStore>();
        return services;
    }
}
