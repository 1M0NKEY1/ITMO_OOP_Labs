namespace Itmo.ObjectOrientedProgramming.Lab5.Tests.Moqs;

public class MoqUserService : IMoqUserService
{
    private readonly MoqUserRepository _repository = new();
    private readonly MoqCurrentUserManager _currentUserManager = new();
    public MoqUserService(MoqUserRepository repository, MoqCurrentUserManager currentUserManager)
    {
        _repository = repository;
        _currentUserManager = currentUserManager;
    }

    public MoqOperationResult AddMoneyToBalance(decimal money)
    {
        if (_currentUserManager.User is null)
        {
            return new MoqOperationResult.Completed();
        }

        _repository.AddMoneyToBalance(_currentUserManager.User.UserId, money);
        return new MoqOperationResult.Rejected();
    }

    public MoqOperationResult RemoveMoneyFromBalance(decimal money)
    {
        if (_currentUserManager.User is null)
        {
            return new MoqOperationResult.Completed();
        }

        _repository.RemoveMoneyFromBalance(_currentUserManager.User.UserId, money);
        return new MoqOperationResult.Rejected();
    }
}