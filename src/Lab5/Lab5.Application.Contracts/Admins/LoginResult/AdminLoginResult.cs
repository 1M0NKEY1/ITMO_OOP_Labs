namespace Lab5.Application.Contracts.Admins.LoginResult;

public abstract record AdminLoginResult
{
    private AdminLoginResult() { }

    public sealed record Success : AdminLoginResult;

    public sealed record NotFound : AdminLoginResult;
}