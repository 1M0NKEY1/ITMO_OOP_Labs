using Lab5.Application.Contracts.Users;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.Login;

public class UserLoginScenario : IScenario
{
    private readonly IUserService _userService;

    public UserLoginScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name => "User Login";
    public void Run()
    {
        long userid = AnsiConsole.Ask<long>("Enter your userid");
        long pin = AnsiConsole.Ask<long>("Enter your pin");

        UserLoginResult result = _userService.Login(userid, pin);

        string message = result switch
        {
            UserLoginResult.Success => "Successful login",
            UserLoginResult.NotFound => "User not found",
            _ => throw new ArgumentOutOfRangeException(nameof(result)),
        };

        AnsiConsole.WriteLine(message);
        AnsiConsole.Ask<string>("Ok");
    }
}