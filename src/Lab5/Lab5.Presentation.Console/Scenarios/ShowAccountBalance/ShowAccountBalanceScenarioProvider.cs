using System.Diagnostics.CodeAnalysis;
using Lab5.Application.Contracts.Users;
using Lab5.Presentation.Console.Scenarios.SecondLayer;

namespace Lab5.Presentation.Console.Scenarios.ShowAccountBalance;

public class ShowAccountBalanceScenarioProvider : ISecondScenarioProvider
{
    private readonly IUserService _service;
    private readonly ICurrentUserService _currentUser;

    public ShowAccountBalanceScenarioProvider(
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

        scenario = new ShowAccountBalanceScenario(_service);
        return true;
    }
}