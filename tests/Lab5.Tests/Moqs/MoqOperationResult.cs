namespace Itmo.ObjectOrientedProgramming.Lab5.Tests.Moqs;

public abstract record MoqOperationResult
{
    private MoqOperationResult() { }
    public sealed record Completed : MoqOperationResult;
    public sealed record Rejected : MoqOperationResult;
}