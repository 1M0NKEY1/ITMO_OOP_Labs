using Lab5.Application.Contracts.Users;
using Lab5.Presentation.Console.Scenarios.FirstLayer;
using Lab5.Presentation.Console.Scenarios.SecondLayer;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.Login;

public class UserLoginScenario : IFirstScenario
{
    private readonly IUserService _userService;
    private readonly SecondScenarioRunner _scenarioRunner;

    public UserLoginScenario(IUserService userService, SecondScenarioRunner scenarioRunner)
    {
        _userService = userService;
        _scenarioRunner = scenarioRunner;
    }

    public string Name => "User Login";
    public void Run()
    {
        string name = AnsiConsole.Ask<string>("Enter your name");
        long pin = AnsiConsole.Ask<long>("Enter your pin");

        UserLoginResult result = _userService.Login(name, pin);

        string message = result switch
        {
            UserLoginResult.Success => "Successful login",
            UserLoginResult.NotFound => "User not found",
            _ => throw new ArgumentOutOfRangeException(nameof(result)),
        };

        _scenarioRunner.Run();

        AnsiConsole.WriteLine(message);
        AnsiConsole.Ask<string>("-------------------");
    }
}