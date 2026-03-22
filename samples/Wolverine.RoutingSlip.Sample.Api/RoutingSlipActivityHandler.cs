using Wolverine.RoutingSlip.Abstractions.Contexts;

namespace Wolverine.RoutingSlip.Sample.Api;

public sealed class RoutingSlipHandler
{
    public ValueTask HandleAsync(RoutingSlipExecutionContext context, CancellationToken ct)
    {
        return ValueTask.CompletedTask;
    }

    public ValueTask HandleAsync(RoutingSlipCompensationContext context, CancellationToken ct)
    {
        return ValueTask.CompletedTask;
    }

}
