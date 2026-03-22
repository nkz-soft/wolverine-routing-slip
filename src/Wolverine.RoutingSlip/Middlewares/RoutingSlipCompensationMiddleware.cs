using Wolverine.RoutingSlip.Abstractions;
using Wolverine.RoutingSlip.Abstractions.Contexts;

namespace Wolverine.RoutingSlip.Middlewares;

/// <summary>
/// Middleware that delegates successful compensation transitions to the coordinator.
/// </summary>
public sealed class RoutingSlipCompensationMiddleware
{
    public ValueTask AfterAsync(RoutingSlipCompensationContext msg, IMessageContext context)
    {
        Console.WriteLine("RoutingSlipCompensationMiddleware:AfterAsync");
        return ValueTask.CompletedTask;
    }
}
