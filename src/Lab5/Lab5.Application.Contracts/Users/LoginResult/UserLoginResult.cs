namespace Lab5.Application.Contracts.Users;

public abstract record UserLoginResult
{
    private UserLoginResult() { }

    protected sealed record Success : UserLoginResult;

    protected sealed record NotFound : UserLoginResult;
}