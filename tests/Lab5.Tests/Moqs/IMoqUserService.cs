namespace Itmo.ObjectOrientedProgramming.Lab5.Tests.Moqs;

public interface IMoqUserService
{
    public MoqOperationResult AddMoneyToBalance(decimal money);
    public MoqOperationResult RemoveMoneyFromBalance(decimal money);
}