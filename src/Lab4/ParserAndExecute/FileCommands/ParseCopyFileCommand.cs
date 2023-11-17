using System;
using System.Collections.Generic;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseCopyFileCommand : CommandHandlerBase
{
    private const string KeyWordOne = "file";
    private const string KeyWordTwo = "copy";
    protected override bool CanHandle(IList<string> parts)
    {
        return parts[0].Equals(KeyWordOne, StringComparison.Ordinal) &&
               parts[1].Equals(KeyWordTwo, StringComparison.Ordinal);
    }

    protected override void Process(IList<string> parts)
    {
        string sourcePath = parts[2];
        string destinationPath = parts[3];
        Execute(sourcePath, destinationPath);
    }

    private static void Execute(string sourcePath, string destinationPath)
    {
        if (File.Exists(sourcePath))
        {
            string sourceAbsolutePath = Path.GetFullPath(sourcePath);
            string destinationAbsolutePath = Path.GetFullPath(destinationPath);

            string fileName = Path.GetFileName(sourcePath);
            string destinationFilePath = Path.Combine(destinationAbsolutePath, fileName);

            File.Copy(sourceAbsolutePath, destinationFilePath, true);
        }
    }
}