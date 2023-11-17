using System;
using System.Collections.Generic;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseShowFileCommand : CommandHandlerBase
{
    private const string KeyWordOne = "file";
    private const string KeyWordTwo = "show";
    private const string KeyWordThree = "-m";
    private const string KeyWordFour = "console";
    protected override bool CanHandle(IList<string> parts)
    {
        return parts.Count == 5 &&
               parts[0].Equals(KeyWordOne, StringComparison.Ordinal) &&
               parts[1].Equals(KeyWordTwo, StringComparison.Ordinal) &&
               parts[3].Equals(KeyWordThree, StringComparison.Ordinal) &&
               parts[4].Equals(KeyWordFour, StringComparison.Ordinal);
    }

    protected override void Process(IList<string> parts)
    {
        string path = parts[2];
        Execute(path, KeyWordFour);
    }

    private static void Execute(string path, string mode)
    {
        string absolutePath = Path.GetFullPath(path);

        if (File.Exists(absolutePath))
        {
            if (mode.Equals(KeyWordFour, StringComparison.Ordinal))
            {
                string fileContent = File.ReadAllText(absolutePath);
                Console.WriteLine(fileContent);
            }
        }
    }
}