using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.TreeCommands;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseTreeListCommand : CommandHandlerBase
{
    private const string KeyWordTree = "tree";
    private const string KeyWordList = "list";
    private const string KeyWordDashD = "-d";
    protected override bool CanHandle(IList<string> parts)
    {
        return parts.Count == 4 &&
               parts[0].Equals(KeyWordTree, StringComparison.Ordinal) &&
               parts[1].Equals(KeyWordList, StringComparison.Ordinal) &&
               parts[2].Equals(KeyWordDashD, StringComparison.Ordinal);
    }

    protected override ICommand? Process(IList<string> parts)
    {
        if (int.TryParse(parts[3], out int depth))
        {
            return new TreeListCommand(depth);
        }

        return null;
    }
}