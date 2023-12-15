using Lab5.Application.Contracts.Users;
using Lab5.Presentation.Console.Scenarios.SecondLayer;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.RemoveMoneyFromBalance;

public class RemoveMoneyScenario : ISecondScenario
{
    private readonly IUserService _userService;

    public RemoveMoneyScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name => "Withdrawal money";
    public void Run()
    {
        decimal money = AnsiConsole.Ask<decimal>("Replenishment money");

        OperationResult result = _userService.AddMoneyToBalance(money);

        string message = result switch
        {
            OperationResult.Completed => "Money removed from the account",
            OperationResult.Rejected => "Check your account",
            _ => throw new ArgumentOutOfRangeException(nameof(result)),
        };

        AnsiConsole.WriteLine("----------------------------");
        AnsiConsole.WriteLine(message);
        AnsiConsole.WriteLine("----------------------------");
    }
}