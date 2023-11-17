using System;
using System.Collections.Generic;
using System.IO;

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

    protected override void Process(IList<string> parts)
    {
        string path = parts[2];
        Execute(path);
    }

    private static void Execute(string path)
    {
        if (Path.IsPathRooted(path))
        {
            Directory.SetCurrentDirectory(path);
        }
        else
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string combinedPath = Path.Combine(currentDirectory, path);

            Directory.SetCurrentDirectory(combinedPath);
        }

        Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}");
    }
}