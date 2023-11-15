using System;
using System.Collections.Generic;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseDisconnectCommand : ICommandHandler
{
    private ICommandHandler? _nextHandler;

    public ParseDisconnectCommand()
    {
        CommandHandlers?.Add(this);
    }

    public IList<ICommandHandler>? CommandHandlers { get; }

    public void SetNextHandler(ICommandHandler handler)
    {
        _nextHandler = handler;
    }

    public void Handle(IList<string> parts)
    {
        const string keyWordOne = "disconnect";
        if (parts[0].Equals(keyWordOne, StringComparison.OrdinalIgnoreCase))
        {
            Execute();
        }
        else
        {
            _nextHandler?.Handle(parts);
        }
    }

    private static FileInfo? Execute()
    {
        return null;
    }
}