namespace Wolverine.RoutingSlip;

public enum RoutingSlipStatus
{
    Pending = 0,
    Running = 1,
    Completed = 2,
    Faulted = 3,
    Compensating = 4,
    Compensated = 5,
}

public sealed class RoutingSlipState
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public required string DefinitionName { get; init; }
    public RoutingSlipStatus Status { get; private set; } = RoutingSlipStatus.Pending;
    public int CurrentStepIndex { get; private set; }
    public List<string> ExecutionLog { get; } = new();

    public void Start() => Status = RoutingSlipStatus.Running;
    public void MarkCompleted() => Status = RoutingSlipStatus.Completed;
    public void MarkFaulted() => Status = RoutingSlipStatus.Faulted;
    public void MarkCompensating() => Status = RoutingSlipStatus.Compensating;
    public void MarkCompensated() => Status = RoutingSlipStatus.Compensated;
    public void Advance() => CurrentStepIndex++;
}
