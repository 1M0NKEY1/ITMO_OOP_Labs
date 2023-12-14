using Lab5.Application.Contracts.Admins;
using Lab5.Application.Contracts.Users;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.ChangeAdminKey;

public class ChangeAdminKeyScenario : IScenario
{
    private readonly IAdminService _adminService;

    public ChangeAdminKeyScenario(IAdminService adminService)
    {
        _adminService = adminService;
    }

    public string Name => "Change administrator key";

    public void Run()
    {
        long adminKey = AnsiConsole.Ask<long>("Enter your new admin_key");

        OperationResult result = _adminService.ChangeAdminKey(adminKey);

        string message = result switch
        {
            OperationResult.Completed => "Key successfully changed",
            OperationResult.Rejected => "Check your account",
            _ => throw new ArgumentOutOfRangeException(nameof(result)),
        };

        AnsiConsole.WriteLine(message);
        AnsiConsole.Ask<string>("Ok");
    }
}