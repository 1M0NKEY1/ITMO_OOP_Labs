using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseDisconnectCommand : CommandHandlerBase
{
    private const string KeyWordDisconnect = "disconnect";
    protected override bool CanHandle(IList<string> parts)
    {
        return parts[0].Equals(KeyWordDisconnect, StringComparison.OrdinalIgnoreCase);
    }

    protected override ICommand? Process(IList<string> parts)
    {
        return new DisconnectCommand();
    }
}