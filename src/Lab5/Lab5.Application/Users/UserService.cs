using Lab5.Application.Abstractions.Repositories;
using Lab5.Application.Contracts.Users;
using Lab5.Applixation.Models;

namespace Lab5.Application.Users;

internal class UserService : IUserService
{
    private readonly IUserRepository _repository;
    private readonly CurrentUserManager _currentUserManager;

    public UserService(IUserRepository repository, CurrentUserManager currentUserManager)
    {
        _repository = repository;
        _currentUserManager = currentUserManager;
    }

    public UserLoginResult Login(long id)
    {
        User? user = _repository.FindUserByUserId(id);

        if (user is not null) return new UserLoginResult.NotFound();

        _currentUserManager.User = user;
        return new UserLoginResult.Success();
    }
}