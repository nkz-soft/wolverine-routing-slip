using Wolverine.RoutingSlip.Abstractions;
using Wolverine.RoutingSlip.Abstractions.Contexts;

namespace Wolverine.RoutingSlip.Middlewares;

/// <summary>
/// Middleware that delegates successful execution transitions to the coordinator.
/// </summary>
public sealed class RoutingSlipExecutionMiddleware
{
    public ValueTask AfterAsync(RoutingSlipExecutionContext msg, IMessageContext context)
    {
        Console.WriteLine("RoutingSlipExecutionMiddleware:AfterAsync");
        return ValueTask.CompletedTask;
    }
}
