namespace Lab5.Application.Contracts.Users;

public abstract record OperationResult
{
    private OperationResult() { }

    public sealed record Completed : OperationResult;

    public sealed record Rejected : OperationResult;
}