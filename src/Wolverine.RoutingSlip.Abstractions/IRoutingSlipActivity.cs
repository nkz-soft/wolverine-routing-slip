namespace Wolverine.RoutingSlip;

public interface IRoutingSlipActivity<in TArguments>
    where TArguments : class
{
    ValueTask<ActivityExecutionResult> ExecuteAsync(TArguments arguments, CancellationToken cancellationToken);
}
