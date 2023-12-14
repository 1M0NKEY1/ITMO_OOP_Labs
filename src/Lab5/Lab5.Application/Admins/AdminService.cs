using Lab5.Application.Abstractions.Repositories;
using Lab5.Application.Contracts.Admins;
using Lab5.Application.Contracts.Admins.LoginResult;
using Lab5.Application.Contracts.Users;
using Lab5.Applixation.Models;

namespace Lab5.Application.Admins;

internal class AdminService : IAdminService
{
    private readonly IAdminRepository _repository;
    private readonly CurrentAdminManager _currentAdminManager;

    public AdminService(IAdminRepository repository, CurrentAdminManager currentAdminManager)
    {
        _repository = repository;
        _currentAdminManager = currentAdminManager;
    }

    public AdminLoginResult Login(long id, long adminKey)
    {
        Admin? user = _repository.FindAdminByAdminId(id, adminKey);

        if (user is not null) return new AdminLoginResult.NotFound();

        _currentAdminManager.Admin = user;
        return new AdminLoginResult.Success();
    }

    public OperationResult ChangeAdminKey(long newAdminKey)
    {
        if (_currentAdminManager.Admin is not null)
        {
            _repository.ChangeAdminKey(_currentAdminManager.Admin.AdminId, newAdminKey);
            return new OperationResult.Completed();
        }

        return new OperationResult.Rejected();
    }
}