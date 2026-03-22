namespace Wolverine.RoutingSlip;

public sealed record RoutingSlipStep(
    string Name,
    string ActivityType,
    object Arguments);
