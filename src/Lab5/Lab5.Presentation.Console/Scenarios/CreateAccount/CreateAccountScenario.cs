using Lab5.Application.Contracts.Users;
using Lab5.Presentation.Console.Scenarios.FirstLayer;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.CreateAccount;

public class CreateAccountScenario : IFirstScenario
{
    private readonly IUserService _userService;

    public CreateAccountScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name => "Create Account";
    public void Run()
    {
        string name = AnsiConsole.Ask<string>("Enter your name");
        long pin = AnsiConsole.Ask<long>("Enter your pin");

        OperationResult result = _userService.CreateAccount(name, pin);

        string message = result switch
        {
            OperationResult.Completed => "Account successfully created",
            OperationResult.Rejected => "Account may be created yet",
            _ => throw new ArgumentOutOfRangeException(nameof(result)),
        };

        AnsiConsole.WriteLine("----------------------------");
        AnsiConsole.WriteLine(message);
        AnsiConsole.WriteLine("----------------------------");
    }
}