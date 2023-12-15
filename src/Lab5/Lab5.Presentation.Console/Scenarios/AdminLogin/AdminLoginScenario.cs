using Lab5.Application.Contracts.Admins;
using Lab5.Application.Contracts.Admins.LoginResult;
using Lab5.Presentation.Console.Scenarios.FirstLayer;
using Lab5.Presentation.Console.Scenarios.SecondLayer;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.AdminLogin;

public class AdminLoginScenario : IFirstScenario
{
    private readonly IAdminService _adminService;
    private readonly SecondScenarioRunner _scenarioRunner;

    public AdminLoginScenario(IAdminService adminService, SecondScenarioRunner scenarioRunner)
    {
        _adminService = adminService;
        _scenarioRunner = scenarioRunner;
    }

    public string Name => "Admin Login";

    public void Run()
    {
        long adminId = AnsiConsole.Ask<long>("Enter your admin_id");
        long adminKey = AnsiConsole.Ask<long>("Enter your admin_key");

        AdminLoginResult result = _adminService.Login(adminId, adminKey);

        string message = result switch
        {
            AdminLoginResult.Success => "Successful login",
            AdminLoginResult.NotFound => "Admin not found",
            _ => throw new ArgumentOutOfRangeException(nameof(result)),
        };

        while (true)
        {
            _scenarioRunner.Run();
            AnsiConsole.WriteLine(message);
            AnsiConsole.Ask<string>("-------------------");
        }
    }
}