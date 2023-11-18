using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseDisconnectCommand : CommandHandlerBase
{
    private const string KeyWordOne = "disconnect";
    protected override bool CanHandle(IList<string> parts)
    {
        return parts[0].Equals(KeyWordOne, StringComparison.OrdinalIgnoreCase);
    }

    protected override void Process(IList<string> parts)
    {
        var disconnectCommand = new DisconnectCommand();
        disconnectCommand.Execute();
    }
}