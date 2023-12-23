using Lab5.Application.Contracts.Admins.LoginResult;
using Lab5.Application.Contracts.Users;

namespace Lab5.Application.Contracts.Admins;

public interface IAdminService
{
    AdminLoginResult Login(long id, long adminKey);
    OperationResult ChangeAdminKey(long newAdminKey);
}