using System.Diagnostics.CodeAnalysis;
using Lab5.Application.Contracts.Admins;
using Lab5.Presentation.Console.Scenarios.FirstLayer;
using Lab5.Presentation.Console.Scenarios.SecondLayer;

namespace Lab5.Presentation.Console.Scenarios.AdminLogin;

public class AdminLoginScenarioProvider : IFirstScenarioProvider
{
    private readonly IAdminService _service;
    private readonly ICurrentAdminService _currentAdmin;
    private readonly SecondScenarioRunner _scenarioRunner;

    public AdminLoginScenarioProvider(
        IAdminService service,
        ICurrentAdminService currentAdmin,
        SecondScenarioRunner scenarioRunner)
    {
        _service = service;
        _currentAdmin = currentAdmin;
        _scenarioRunner = scenarioRunner;
    }

    public bool TryGetScenario(
        [NotNullWhen(true)] out IFirstScenario? scenario)
    {
        if (_currentAdmin.Admin is not null)
        {
            scenario = null;
            return false;
        }

        scenario = new AdminLoginScenario(_service, _scenarioRunner);
        return true;
    }
}