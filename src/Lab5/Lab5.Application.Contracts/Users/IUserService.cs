namespace Lab5.Application.Contracts.Users;

public interface IUserService
{
    UserLoginResult Login(long id);
}