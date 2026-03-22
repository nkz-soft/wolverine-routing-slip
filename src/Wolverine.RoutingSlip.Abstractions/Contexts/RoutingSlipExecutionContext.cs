namespace Wolverine.RoutingSlip.Abstractions.Contexts;

/// <summary>
///     A message that is sent to execute the next activity in a routing slip
/// </summary>
[Serializable]
public sealed record RoutingSlipExecutionContext(Guid Id);
