using System;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseDisconnectCommand : CommandParser
{
    public override void ParseCommand(string command)
    {
        if (command.Equals("disconnect", StringComparison.OrdinalIgnoreCase))
        {
            Execute
        }
        else
        {
            NextCommand?.ParseCommand(command);
        }
    }
}