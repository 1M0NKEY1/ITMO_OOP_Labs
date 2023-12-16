using Itmo.ObjectOrientedProgramming.Lab4.Commands.Strategy;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class ConnectCommand : ICommand
{
    private readonly string _address;

    private IStrategy? _strategy;

    public ConnectCommand(string address, string mode)
    {
        _address = address;
        Mode = mode;
    }

    public string Mode { get; }

    public void ChangeStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Execute()
    {
        _strategy?.Connect(_address, Mode);
    }
}