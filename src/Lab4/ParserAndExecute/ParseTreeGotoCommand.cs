using System;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseTreeGotoCommand : CommandParser
{
    public override void ParseCommand(string command)
    {
        string[] parts = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length == 3 && parts[0] == "tree" && parts[1] == "goto")
        {
            string path = parts[2];
            ExecuteTreeGotoCommand(path);
        }
        else
        {
            NextCommand?.ParseCommand(command);
        }
    }
}