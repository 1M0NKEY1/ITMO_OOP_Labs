using System;
using System.Collections.Generic;

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
        Execute();
    }

    private static void Execute()
    {
        Environment.Exit(0);
    }
}