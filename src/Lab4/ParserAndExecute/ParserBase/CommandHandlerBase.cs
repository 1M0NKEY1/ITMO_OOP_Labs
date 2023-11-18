using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public abstract class CommandHandlerBase : ICommandHandler
{
    private ICommandHandler? _nextHandler;

    public void SetNextHandler(ICommandHandler? handler)
    {
        _nextHandler?.SetNextHandler(handler);
        _nextHandler ??= handler;
    }

    public void Handle(IList<string> parts)
    {
        if (CanHandle(parts))
        {
            Process(parts);
        }
        else
        {
            _nextHandler?.Handle(parts);
        }
    }

    protected abstract bool CanHandle(IList<string> parts);
    protected abstract void Process(IList<string> parts);
}