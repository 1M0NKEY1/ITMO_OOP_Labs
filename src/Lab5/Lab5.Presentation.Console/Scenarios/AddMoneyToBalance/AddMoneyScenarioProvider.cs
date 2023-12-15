using System.Diagnostics.CodeAnalysis;
using Lab5.Application.Contracts.Users;
using Lab5.Presentation.Console.Scenarios.SecondLayer;

namespace Lab5.Presentation.Console.Scenarios.AddMoneyToBalance;

public class AddMoneyScenarioProvider : ISecondScenarioProvider
{
    private readonly IUserService _service;
    private readonly ICurrentUserService _currentUser;

    public AddMoneyScenarioProvider(
        IUserService service,
        ICurrentUserService currentUser)
    {
        _service = service;
        _currentUser = currentUser;
    }

    public bool TryGetScenario(
        [NotNullWhen(true)] out ISecondScenario? scenario)
    {
        if (_currentUser.User is not null)
        {
            scenario = null;
            return false;
        }

        scenario = new AddMoneyScenario(_service);
        return true;
    }
}