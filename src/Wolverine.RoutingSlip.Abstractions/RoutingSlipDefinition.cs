namespace Wolverine.RoutingSlip;

public sealed class RoutingSlipDefinition
{
    public required string Name { get; init; }
    public required IReadOnlyList<RoutingSlipStep> Steps { get; init; }
}
