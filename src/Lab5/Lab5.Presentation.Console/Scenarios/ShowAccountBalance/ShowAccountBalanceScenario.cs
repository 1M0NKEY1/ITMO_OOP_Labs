using System.Globalization;
using Lab5.Application.Contracts.Users;
using Lab5.Presentation.Console.Scenarios.SecondLayer;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.ShowAccountBalance;

public class ShowAccountBalanceScenario : ISecondScenario
{
    private readonly IUserService _userService;

    public ShowAccountBalanceScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name => "Show account balance";
    public void Run()
    {
        decimal result = _userService.ShowAccountBalance();

        AnsiConsole.WriteLine(CultureInfo.CurrentCulture, result);
        AnsiConsole.Ask<string>("-------------------");
    }
}