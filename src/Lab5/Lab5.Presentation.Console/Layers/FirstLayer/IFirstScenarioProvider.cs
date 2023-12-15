using System.Diagnostics.CodeAnalysis;

namespace Lab5.Presentation.Console.Scenarios.FirstLayer;

public interface IFirstScenarioProvider
{
    bool TryGetScenario([NotNullWhen(true)] out IFirstScenario? scenario);
}