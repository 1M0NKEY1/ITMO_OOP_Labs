using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.TreeCommands;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseTreeListCommand : CommandHandlerBase
{
    private const string KeyWordOne = "tree";
    private const string KeyWordTwo = "list";
    private const string KeyWordThree = "-d";
    protected override bool CanHandle(IList<string> parts)
    {
        return parts.Count == 4 &&
               parts[0].Equals(KeyWordOne, StringComparison.Ordinal) &&
               parts[1].Equals(KeyWordTwo, StringComparison.Ordinal) &&
               parts[2].Equals(KeyWordThree, StringComparison.Ordinal);
    }

    protected override void Process(IList<string> parts)
    {
        if (int.TryParse(parts[3], out int depth))
        {
            var listCommand = new TreeListCommand(depth);
            listCommand.Execute();
        }
    }
}