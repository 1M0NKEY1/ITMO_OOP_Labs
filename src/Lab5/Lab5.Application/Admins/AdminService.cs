using Lab5.Application.Abstractions.Repositories;
using Lab5.Application.Contracts.Users;
using Lab5.Applixation.Models;

namespace Lab5.Application.Users;

internal class AdminService : IAdminService
{
    private readonly IAdminRepository _repository;
    private readonly CurrentAdminManager _currentAdminManager;

    public AdminService(IAdminRepository repository, CurrentAdminManager currentAdminManager)
    {
        _repository = repository;
        _currentAdminManager = currentAdminManager;
    }

    public AdminLoginResult Login(long id)
    {
        Admin? user = _repository.FindAdminByAdminId(id);

        if (user is not null) return new AdminLoginResult.NotFound();

        _currentAdminManager.Admin = user;
        return new AdminLoginResult.Success();
    }
}