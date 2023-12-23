using Itmo.ObjectOrientedProgramming.Lab5.Tests.Moqs;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab5.Tests.Tests;

public class TestRemoveMoney
{
    [Fact]
    public void RemoveMoneyFromBalanceShouldDecreaseBalance()
    {
        const decimal StartBalance = 100;
        const decimal MinusMoney = 50;
        const decimal ExpectedBalance = 100;
        var user = new MoqUser("Egor", 1234);

        user.Balance = StartBalance;
        var repository = new MoqUserRepository();

        var currentUserManager = new MoqCurrentUserManager();

        var service = new MoqUserService(repository, currentUserManager);

        MoqOperationResult result = service.RemoveMoneyFromBalance(MinusMoney);

        Assert.True(result is MoqOperationResult.Completed);
        Assert.Equal(ExpectedBalance, user.Balance);
    }
}