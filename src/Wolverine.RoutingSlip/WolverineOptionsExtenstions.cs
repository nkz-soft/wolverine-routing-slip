using Wolverine.RoutingSlip.Abstractions.Contexts;
using Wolverine.RoutingSlip.Middlewares;

namespace Wolverine.RoutingSlip;

public static class WolverineOptionsExtensions
{
    public static WolverineOptions UseRoutingSlip(this WolverineOptions options)
    {
        ArgumentNullException.ThrowIfNull(options);

        options.Policies
            .ForMessagesOfType<RoutingSlipExecutionContext>()
            .AddMiddleware(typeof(RoutingSlipExecutionMiddleware));

        options.Policies
            .ForMessagesOfType<RoutingSlipCompensationContext>()
            .AddMiddleware(typeof(RoutingSlipCompensationMiddleware));

        return options;
    }

}
