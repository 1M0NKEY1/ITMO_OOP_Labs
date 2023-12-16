using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.TreeCommands;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseTreeGotoCommand : CommandHandlerBase
{
    private const string KeyWordTree = "tree";
    private const string KeyWordGoto = "goto";
    protected override bool CanHandle(IList<string> parts)
    {
        return parts.Count == 3 &&
               parts[0].Equals(KeyWordTree, StringComparison.Ordinal) &&
               parts[1].Equals(KeyWordGoto, StringComparison.Ordinal);
    }

    protected override ICommand? Process(IList<string> parts)
    {
        string path = parts[2];
        return new TreeGotoCommand(path);
    }
}