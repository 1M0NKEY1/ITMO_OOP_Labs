namespace Lab5.Application.Contracts.Users;

public abstract record AdminLoginResult
{
    private AdminLoginResult() { }

    protected sealed record Success : AdminLoginResult;

    protected sealed record NotFound : AdminLoginResult;
}