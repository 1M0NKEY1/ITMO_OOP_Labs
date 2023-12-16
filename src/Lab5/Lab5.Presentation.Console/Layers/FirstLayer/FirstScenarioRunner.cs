using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.FirstLayer;

public class FirstScenarioRunner
{
    private readonly IEnumerable<IFirstScenarioProvider> _providers;

    public FirstScenarioRunner(IEnumerable<IFirstScenarioProvider> providers)
    {
        _providers = providers;
    }

    public void Run()
    {
        IEnumerable<IFirstScenario> scenarios = GetScenarios();

        SelectionPrompt<IFirstScenario> selector = new SelectionPrompt<IFirstScenario>()
            .Title("Select action")
            .AddChoices(scenarios)
            .UseConverter(x => x.Name);

        IFirstScenario scenario = AnsiConsole.Prompt(selector);
        scenario.Run();
    }

    private IEnumerable<IFirstScenario> GetScenarios()
    {
        foreach (IFirstScenarioProvider provider in _providers)
        {
            if (provider.TryGetScenario(out IFirstScenario? scenario))
                yield return scenario;
        }
    }
}