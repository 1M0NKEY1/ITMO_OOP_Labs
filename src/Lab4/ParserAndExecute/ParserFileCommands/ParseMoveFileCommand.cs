using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseMoveFileCommand : CommandHandlerBase
{
    private const string KeyWordOne = "file";
    private const string KeyWordTwo = "move";
    protected override bool CanHandle(IList<string> parts)
    {
        return parts[0].Equals(KeyWordOne, StringComparison.Ordinal) &&
               parts[1].Equals(KeyWordTwo, StringComparison.Ordinal);
    }

    protected override void Process(IList<string> parts)
    {
        string sourcePath = parts[2];
        string destinationPath = parts[3];
        var moveCommand = new MoveFileCommand(sourcePath, destinationPath);

        moveCommand.Execute();
    }
}