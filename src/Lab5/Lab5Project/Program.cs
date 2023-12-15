using DataAccess.Extensions;
using Lab5.Application.Extensions;
using Lab5.Presentation.Console.Extansions;
using Lab5.Presentation.Console.Scenarios.FirstLayer;
using Microsoft.Extensions.DependencyInjection;
using Spectre.Console;

var collection = new ServiceCollection();

collection
    .AddApplication()
    .AddInfrastructureDataAccess(configuration =>
    {
        configuration.Host = "localhost";
        configuration.Port = 6432;
        configuration.Username = "postgres";
        configuration.Password = "postgres";
        configuration.Database = "postgres";
        configuration.SslMode = "Prefer";
    })
    .AddPresentationConsole();

ServiceProvider provider = collection.BuildServiceProvider();
using IServiceScope scope = provider.CreateScope();

scope.UseInfrastructureDataAccess();

FirstScenarioRunner cloneScenarioRunner = scope.ServiceProvider
    .GetRequiredService<FirstScenarioRunner>();

while (true)
{
    cloneScenarioRunner.Run();
    AnsiConsole.Clear();
}