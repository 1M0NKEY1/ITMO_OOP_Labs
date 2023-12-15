using Lab5.Presentation.Console.Scenarios.AddMoneyToBalance;
using Lab5.Presentation.Console.Scenarios.AdminLogin;
using Lab5.Presentation.Console.Scenarios.ChangeAdminKey;
using Lab5.Presentation.Console.Scenarios.CreateAccount;
using Lab5.Presentation.Console.Scenarios.FirstLayer;
using Lab5.Presentation.Console.Scenarios.Login;
using Lab5.Presentation.Console.Scenarios.RemoveMoneyFromBalance;
using Lab5.Presentation.Console.Scenarios.SecondLayer;
using Lab5.Presentation.Console.Scenarios.ShowAccountBalance;
using Lab5.Presentation.Console.Scenarios.ShowAccountHistory;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5.Presentation.Console.Extansions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPresentationConsole(this IServiceCollection collection)
    {
        collection.AddScoped<FirstScenarioRunner>();
        collection.AddScoped<IFirstScenario, UserLoginScenario>();
        collection.AddScoped<IFirstScenario, AdminLoginScenario>();
        collection.AddScoped<IFirstScenario, CreateAccountScenario>();
        collection.AddScoped<IFirstScenarioProvider, UserLoginScenarioProvider>();
        collection.AddScoped<IFirstScenarioProvider, AdminLoginScenarioProvider>();
        collection.AddScoped<IFirstScenarioProvider, CreateAccountScenarioProvider>();

        collection.AddScoped<SecondScenarioRunner>();
        collection.AddScoped<ISecondScenario, AddMoneyScenario>();
        collection.AddScoped<ISecondScenario, RemoveMoneyScenario>();
        collection.AddScoped<ISecondScenario, ShowAccountBalanceScenario>();
        collection.AddScoped<ISecondScenario, ShowAccountHistoryScenario>();
        collection.AddScoped<ISecondScenario, ChangeAdminKeyScenario>();
        collection.AddScoped<ISecondScenarioProvider, AddMoneyScenarioProvider>();
        collection.AddScoped<ISecondScenarioProvider, RemoveMoneyScenarioProvider>();
        collection.AddScoped<ISecondScenarioProvider, ShowAccountBalanceScenarioProvider>();
        collection.AddScoped<ISecondScenarioProvider, ShowAccountHistoryScenarioProvider>();
        collection.AddScoped<ISecondScenarioProvider, ChangeAdminKeyScenarioProvider>();

        return collection;
    }
}