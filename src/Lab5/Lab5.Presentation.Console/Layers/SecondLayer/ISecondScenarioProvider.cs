using System.Diagnostics.CodeAnalysis;

namespace Lab5.Presentation.Console.Scenarios.SecondLayer;

public interface ISecondScenarioProvider
{
    bool TryGetScenario([NotNullWhen(true)] out ISecondScenario? scenario);
}