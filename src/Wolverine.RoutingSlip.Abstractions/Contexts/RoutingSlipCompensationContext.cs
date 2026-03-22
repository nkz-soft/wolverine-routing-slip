namespace Wolverine.RoutingSlip.Abstractions.Contexts;

/// <summary>
///     A message that is sent to compensate the next activity in a routing slip
/// </summary>
[Serializable]
public sealed record RoutingSlipCompensationContext(Guid ExecutionId);
