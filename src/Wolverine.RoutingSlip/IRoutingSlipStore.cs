namespace Wolverine.RoutingSlip;

public interface IRoutingSlipStore
{
    Task SaveAsync(RoutingSlipState state, CancellationToken cancellationToken);
    Task<RoutingSlipState?> LoadAsync(Guid id, CancellationToken cancellationToken);
}
