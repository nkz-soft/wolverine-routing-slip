namespace Wolverine.RoutingSlip;

public interface IRoutingSlipCompensation<in TLog>
    where TLog : class
{
    ValueTask CompensateAsync(TLog log, CancellationToken cancellationToken);
}
