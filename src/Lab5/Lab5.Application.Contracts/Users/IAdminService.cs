namespace Lab5.Application.Contracts.Users;

public interface IAdminService
{
    AdminLoginResult Login(long id);
}