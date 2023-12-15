using Lab5.Application.Abstractions.Repositories;
using Lab5.Application.Contracts.Users;
using Lab5.Applixation.Models;

namespace Lab5.Application.Users;

internal class UserService : IUserService
{
    private readonly IUserRepository _repository;
    private readonly CurrentUserManager _currentUserManager;
    private User? _user;

    public UserService(IUserRepository repository, CurrentUserManager currentUserManager)
    {
        _repository = repository;
        _currentUserManager = currentUserManager;
    }

    public UserLoginResult Login(string name, long pin)
    {
        _user = _repository.FindUserByUserName(name, pin);

        if (_user is null) return new UserLoginResult.NotFound();

        _currentUserManager.User = _user;
        return new UserLoginResult.Success();
    }

    public OperationResult CreateAccount(string name, long pin)
    {
        _repository.CreateAccount(name, pin);
        return new OperationResult.Completed();
    }

    public decimal ShowAccountBalance()
    {
        if (_currentUserManager.User is null) return 0;

        return _repository.ShowAccountBalance(_currentUserManager.User.UserId);
    }

    public OperationResult AddMoneyToBalance(decimal money)
    {
        if (_currentUserManager.User is null)
        {
            return new OperationResult.Rejected();
        }

        _repository.RemoveMoneyFromBalance(_currentUserManager.User.UserId, money);
        return new OperationResult.Completed();
    }

    public OperationResult RemoveMoneyFromBalance(decimal money)
    {
        if (_currentUserManager.User is null)
        {
            return new OperationResult.Rejected();
        }

        _repository.RemoveMoneyFromBalance(_currentUserManager.User.UserId, money);
        return new OperationResult.Completed();
    }

    public IList<string>? ShowAccountHistory()
    {
        if (_currentUserManager.User is null) return null;

        return _repository.ShowAccountHistory(_currentUserManager.User.UserId);
    }
}