using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.TreeCommands;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseTreeGotoCommand : CommandHandlerBase
{
    private const string KeyWordOne = "tree";
    private const string KeyWordTwo = "goto";
    protected override bool CanHandle(IList<string> parts)
    {
        return parts.Count == 3 &&
               parts[0].Equals(KeyWordOne, StringComparison.Ordinal) &&
               parts[1].Equals(KeyWordTwo, StringComparison.Ordinal);
    }

    protected override ICommand? Process(IList<string> parts)
    {
        string path = parts[2];
        return new TreeGotoCommand(path);
    }
}