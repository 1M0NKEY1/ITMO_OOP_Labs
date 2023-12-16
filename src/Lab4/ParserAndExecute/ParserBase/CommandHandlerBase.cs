using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public abstract class CommandHandlerBase : ICommandHandler
{
    private ICommandHandler? _nextHandler;

    public void SetNextHandler(ICommandHandler? handler)
    {
        _nextHandler?.SetNextHandler(handler);
        _nextHandler ??= handler;
    }

    public ICommand? Handle(IList<string> parts)
    {
        if (CanHandle(parts))
        {
            return Process(parts);
        }
        else
        {
            return _nextHandler?.Handle(parts);
        }
    }

    protected abstract bool CanHandle(IList<string> parts);
    protected abstract ICommand? Process(IList<string> parts);
}