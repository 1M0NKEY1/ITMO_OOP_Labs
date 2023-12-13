namespace Lab5.Application.Contracts.Users;

public abstract record AdminLoginResult
{
    private AdminLoginResult() { }

    public sealed record Success : AdminLoginResult;

    public sealed record NotFound : AdminLoginResult;
}