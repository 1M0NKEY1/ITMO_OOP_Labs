using Lab5.Application.Contracts.Users;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.CreateAccount;

public class CreateAccountScenario : IScenario
{
    private readonly IUserService _userService;

    public CreateAccountScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name => "Create Account";
    public void Run()
    {
        long userid = AnsiConsole.Ask<long>("Enter your userid");
        string name = AnsiConsole.Ask<string>("Enter your name");
        long pin = AnsiConsole.Ask<long>("Enter your pin");

        OperationResult result = _userService.CreateAccount(userid, name, pin);

        string message = result switch
        {
            OperationResult.Completed => "Account successfully created",
            OperationResult.Rejected => "Account may be created yet",
            _ => throw new ArgumentOutOfRangeException(nameof(result)),
        };

        AnsiConsole.WriteLine(message);
        AnsiConsole.Ask<string>("Ok");
    }
}