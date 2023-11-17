using System;
using System.Collections.Generic;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseRenameFileCommand : CommandHandlerBase
{
    private const string KeyWordOne = "file";
    private const string KeyWordTwo = "rename";
    protected override bool CanHandle(IList<string> parts)
    {
        return parts[0].Equals(KeyWordOne, StringComparison.Ordinal) &&
               parts[1].Equals(KeyWordTwo, StringComparison.Ordinal);
    }

    protected override void Process(IList<string> parts)
    {
        string path = parts[2];
        string newName = parts[3];
        Execute(path, newName);
    }

    private static void Execute(string path, string newName)
    {
        string absolutePath = Path.GetFullPath(path);
        string directoryPath = Path.GetDirectoryName(absolutePath) ?? string.Empty;
        string newFilePath = Path.Combine(directoryPath, newName);

        if (File.Exists(absolutePath))
        {
            File.Copy(absolutePath, newFilePath, true);
            File.Delete(absolutePath);
        }
    }
}