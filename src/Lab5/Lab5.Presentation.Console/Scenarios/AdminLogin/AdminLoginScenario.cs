using Lab5.Application.Contracts.Admins;
using Lab5.Application.Contracts.Admins.LoginResult;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.AdminLogin;

public class AdminLoginScenario : IScenario
{
    private readonly IAdminService _adminService;

    public AdminLoginScenario(IAdminService adminService)
    {
        _adminService = adminService;
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

        AnsiConsole.WriteLine(message);
        AnsiConsole.Ask<string>("Ok");
    }
}