using System;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseTreeListCommand : CommandParser
{
    public override void ParseCommand(string command)
    {
        string[] parts = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length == 4 && parts[0] == "tree" && parts[1] == "list" && parts[2] == "-d")
        {
            if (int.TryParse(parts[3], out int depth))
            {
                ExecuteTreeListCommand(depth);
            }
        }
        else
        {
            NextCommand?.ParseCommand(command);
        }
    }
}