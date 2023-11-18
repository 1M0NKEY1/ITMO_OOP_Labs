using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseDeleteFileCommand : CommandHandlerBase
{
    private const string KeyWordOne = "file";
    private const string KeyWordTwo = "delete";
    protected override bool CanHandle(IList<string> parts)
    {
        return parts[0].Equals(KeyWordOne, StringComparison.Ordinal) &&
               parts[1].Equals(KeyWordTwo, StringComparison.Ordinal);
    }

    protected override void Process(IList<string> parts)
    {
        string path = parts[2];
        var deleteCommand = new DeleteFileCommand(path);
        deleteCommand.Execute();
    }
}