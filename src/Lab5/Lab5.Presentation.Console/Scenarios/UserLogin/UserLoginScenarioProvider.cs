using System.Diagnostics.CodeAnalysis;
using Lab5.Application.Contracts.Users;
using Lab5.Presentation.Console.Scenarios.FirstLayer;
using Lab5.Presentation.Console.Scenarios.SecondLayer;

namespace Lab5.Presentation.Console.Scenarios.Login;

public class UserLoginScenarioProvider : IFirstScenarioProvider
{
    private readonly IUserService _service;
    private readonly ICurrentUserService _currentUser;
    private readonly SecondScenarioRunner _scenarioRunner;

    public UserLoginScenarioProvider(
        IUserService service,
        ICurrentUserService currentUser,
        SecondScenarioRunner secondScenarioRunner)
    {
        _service = service;
        _currentUser = currentUser;
        _scenarioRunner = secondScenarioRunner;
    }

    public bool TryGetScenario(
        [NotNullWhen(true)] out IFirstScenario? scenario)
    {
        if (_currentUser.User is not null)
        {
            scenario = null;
            return false;
        }

        scenario = new UserLoginScenario(_service, _scenarioRunner);
        return true;
    }
}