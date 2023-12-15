using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.SecondLayer;

public class SecondScenarioRunner
{
    private readonly IEnumerable<ISecondScenarioProvider> _providers;

    public SecondScenarioRunner(IEnumerable<ISecondScenarioProvider> providers)
    {
        _providers = providers;
    }

    public void Run()
    {
        IEnumerable<ISecondScenario> scenarios = GetScenarios();

        SelectionPrompt<ISecondScenario> selector = new SelectionPrompt<ISecondScenario>()
            .Title("Select action")
            .AddChoices(scenarios)
            .UseConverter(x => x.Name);

        ISecondScenario scenario = AnsiConsole.Prompt(selector);
        while (true)
        {
            scenario.Run();
        }
    }

    private IEnumerable<ISecondScenario> GetScenarios()
    {
        foreach (ISecondScenarioProvider provider in _providers)
        {
            if (provider.TryGetScenario(out ISecondScenario? scenario))
                yield return scenario;
        }
    }
}