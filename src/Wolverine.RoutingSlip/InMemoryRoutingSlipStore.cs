using System.Collections.Concurrent;

namespace Wolverine.RoutingSlip;

public sealed class InMemoryRoutingSlipStore : IRoutingSlipStore
{
    private readonly ConcurrentDictionary<Guid, RoutingSlipState> _states = new();

    public Task SaveAsync(RoutingSlipState state, CancellationToken cancellationToken)
    {
        _states[state.Id] = state;
        return Task.CompletedTask;
    }

    public Task<RoutingSlipState?> LoadAsync(Guid id, CancellationToken cancellationToken)
    {
        _states.TryGetValue(id, out var state);
        return Task.FromResult(state);
    }
}
