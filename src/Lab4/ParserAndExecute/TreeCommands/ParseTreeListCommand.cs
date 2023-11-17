using System;
using System.Collections.Generic;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseTreeListCommand : CommandHandlerBase
{
    private const string KeyWordOne = "tree";
    private const string KeyWordTwo = "list";
    private const string KeyWordThree = "-d";
    protected override bool CanHandle(IList<string> parts)
    {
        return parts.Count == 4 &&
               parts[0].Equals(KeyWordOne, StringComparison.Ordinal) &&
               parts[1].Equals(KeyWordTwo, StringComparison.Ordinal) &&
               parts[2].Equals(KeyWordThree, StringComparison.Ordinal);
    }

    protected override void Process(IList<string> parts)
    {
        if (int.TryParse(parts[3], out int depth))
        {
            Execute(depth);
        }
    }

    private static void Execute(int depth)
    {
        string basePath = Directory.GetCurrentDirectory();
        ListDirectoriesAndFiles(basePath, depth, 0);
    }

    private static void ListDirectoriesAndFiles(string path, int maxDepth, int currentDepth)
    {
        if (currentDepth > maxDepth)
            return;

        IList<string> directories = Directory.GetDirectories(path);
        IList<string> files = Directory.GetFiles(path);

        foreach (string directory in directories)
        {
            Console.WriteLine("Directory: " + directory);
            ListDirectoriesAndFiles(directory, maxDepth, currentDepth + 1);
        }

        foreach (string file in files)
        {
            Console.WriteLine("File: " + file);
        }
    }
}