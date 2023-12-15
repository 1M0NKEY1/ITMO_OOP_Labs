using Lab5.Application.Contracts.Users;
using Lab5.Presentation.Console.Scenarios.SecondLayer;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.ShowAccountHistory;

public class ShowAccountHistoryScenario : ISecondScenario
{
    private readonly IUserService _userService;

    public ShowAccountHistoryScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name => "Show account history";
    public void Run()
    {
        IList<string>? result = _userService.ShowAccountHistory();

        if (result != null)
        {
            foreach (string operation in result)
            {
                AnsiConsole.WriteLine(operation);
            }
        }

        AnsiConsole.Ask<string>("-------------------");
    }
}