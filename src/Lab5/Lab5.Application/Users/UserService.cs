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

    public UserLoginResult Login(long id, long pin)
    {
        _user = _repository.FindUserByUserId(id, pin);

        if (_user is not null) return new UserLoginResult.NotFound();

        _currentUserManager.User = _user;
        return new UserLoginResult.Success();
    }

    public OperationResult CreateAccount(long id, string name, long pin)
    {
        User? user = _repository.FindUserByUserId(id, pin);
        if (user is null)
        {
            _repository.CreateAccount(id, name, pin);
            return new OperationResult.Completed();
        }

        return new OperationResult.Rejected();
    }

    public decimal ShowAccountBalance()
    {
        if (_currentUserManager.User != null) return _repository.ShowAccountBalance(_currentUserManager.User.UserId);
        return 0;
    }

    public OperationResult AddMoneyToBalance(decimal money)
    {
        if (_currentUserManager.User != null)
        {
            _repository.AddMoneyToBalance(_currentUserManager.User.UserId, money);
            return new OperationResult.Completed();
        }

        return new OperationResult.Rejected();
    }

    public OperationResult RemoveMoneyFromBalance(decimal money)
    {
        if (_currentUserManager.User != null)
        {
            _repository.RemoveMoneyFromBalance(_currentUserManager.User.UserId, money);
            return new OperationResult.Completed();
        }

        return new OperationResult.Rejected();
    }

    public IList<string>? ShowAccountHistory()
    {
        if (_currentUserManager.User != null) return _repository.ShowAccountHistory(_currentUserManager.User.UserId);
        return null;
    }
}