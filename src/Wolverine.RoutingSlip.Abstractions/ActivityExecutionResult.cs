namespace Wolverine.RoutingSlip;

public sealed record ActivityExecutionResult(
    bool IsSuccessful,
    object? CompensationLog = null,
    string? Error = null)
{
    public static ActivityExecutionResult Success(object? compensationLog = null) =>
        new(true, compensationLog);

    public static ActivityExecutionResult Failure(string error) =>
        new(false, null, error);
}
