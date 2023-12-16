using Lab5.Application.Contracts.Users;
using Lab5.Presentation.Console.Scenarios.SecondLayer;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.AddMoneyToBalance;

public class AddMoneyScenario : ISecondScenario
{
    private readonly IUserService _userService;

    public AddMoneyScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name => "Replenishment money";
    public void Run()
    {
        decimal money = AnsiConsole.Ask<decimal>("Replenishment money");

        OperationResult result = _userService.AddMoneyToBalance(money);

        string message = result switch
        {
            OperationResult.Completed => "Money added to the account",
            OperationResult.Rejected => "Check your account",
            _ => throw new ArgumentOutOfRangeException(nameof(result)),
        };

        AnsiConsole.WriteLine("----------------------------");
        AnsiConsole.WriteLine(message);
        AnsiConsole.WriteLine("----------------------------");
    }
}