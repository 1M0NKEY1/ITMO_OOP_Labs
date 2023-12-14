using Lab5.Presentation.Console.Scenarios.AddMoneyToBalance;
using Lab5.Presentation.Console.Scenarios.AdminLogin;
using Lab5.Presentation.Console.Scenarios.ChangeAdminKey;
using Lab5.Presentation.Console.Scenarios.CreateAccount;
using Lab5.Presentation.Console.Scenarios.Login;
using Lab5.Presentation.Console.Scenarios.RemoveMoneyFromBalance;
using Lab5.Presentation.Console.Scenarios.ShowAccountBalance;
using Lab5.Presentation.Console.Scenarios.ShowAccountHistory;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5.Presentation.Console.Extansions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPresentationConsole(this IServiceCollection collection)
    {
        collection.AddScoped<ScenarioRunner>();

        collection.AddScoped<IScenarioProvider, UserLoginScenarioProvider>();
        collection.AddScoped<IScenarioProvider, CreateAccountScenarioProvider>();
        collection.AddScoped<IScenarioProvider, AddMoneyScenarioProvider>();
        collection.AddScoped<IScenarioProvider, RemoveMoneyScenarioProvider>();
        collection.AddScoped<IScenarioProvider, ShowAccountBalanceScenarioProvider>();
        collection.AddScoped<IScenarioProvider, ShowAccountHistoryScenarioProvider>();

        collection.AddScoped<IScenarioProvider, AdminLoginScenarioProvider>();
        collection.AddScoped<IScenarioProvider, ChangeAdminKeyScenarioProvider>();

        return collection;
    }
}