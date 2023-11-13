using System;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseConnectCommand
{
    private bool TryParseConnectCommand(string input, out string address, out string mode)
    {
        address = null;
        mode = null;

        string[] parts = input.Split(' ');
        if (parts.Length >= 2 && parts[0].Equals("connect", StringComparison.OrdinalIgnoreCase))
        {
            address = parts[1];

            for (int i = 2; i < parts.Length; i++)
            {
                if (parts[i].Equals("-m", StringComparison.OrdinalIgnoreCase) && i + 1 < parts.Length)
                {
                    mode = parts[i + 1];
                    break;
                }
            }

            if (mode == null)
            {
                mode = "default";
            }

            return true;
        }

        return false;
    }
}