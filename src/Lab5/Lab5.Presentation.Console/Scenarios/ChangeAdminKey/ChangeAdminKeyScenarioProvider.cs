using System.Diagnostics.CodeAnalysis;
using Lab5.Application.Contracts.Admins;
using Lab5.Presentation.Console.Scenarios.SecondLayer;

namespace Lab5.Presentation.Console.Scenarios.ChangeAdminKey;

public class ChangeAdminKeyScenarioProvider : ISecondScenarioProvider
{
    private readonly IAdminService _service;
    private readonly ICurrentAdminService _currentAdmin;

    public ChangeAdminKeyScenarioProvider(
        IAdminService service,
        ICurrentAdminService currentAdmin)
    {
        _service = service;
        _currentAdmin = currentAdmin;
    }

    public bool TryGetScenario(
        [NotNullWhen(true)] out ISecondScenario? scenario)
    {
        if (_currentAdmin.Admin is not null)
        {
            scenario = null;
            return false;
        }

        scenario = new ChangeAdminKeyScenario(_service);
        return true;
    }
}