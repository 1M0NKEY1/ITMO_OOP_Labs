namespace Itmo.ObjectOrientedProgramming.Lab5.Tests.Moqs;

public interface IMoqUserRepository
{
    void AddMoneyToBalance(long id, decimal money);
    public void RemoveMoneyFromBalance(long id, decimal money);
}