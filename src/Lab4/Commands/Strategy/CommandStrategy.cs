using System;
using System.Collections.Generic;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.Strategy;

public class CommandStrategy : IStrategy
{
    public void Connect(string address, string mode)
    {
        const string KeyWordLocal = "local";
        if (mode.Equals(KeyWordLocal, StringComparison.Ordinal))
        {
            var fileInfo = new FileInfo(address);

            if (fileInfo is { Exists: true, Directory.Exists: true })
            {
                Console.WriteLine($"Connect to local file system: '{fileInfo.FullName}'");
            }
        }
    }

    public void Disconnect()
    {
        Environment.Exit(0);
    }

    public void CopyFile(string sourcePath, string destinationPath)
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

    public void DeleteFile(string path)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
        }
    }

    public void MoveFile(string sourcePath, string destinationPath)
    {
        if (File.Exists(sourcePath))
        {
            string sourceAbsolutePath = Path.GetFullPath(sourcePath);
            string destinationAbsolutePath = Path.GetFullPath(destinationPath);

            string fileName = Path.GetFileName(sourceAbsolutePath);
            string destinationFilePath = Path.Combine(destinationAbsolutePath, fileName);

            File.Move(sourceAbsolutePath, destinationFilePath);
        }
    }

    public void RenameFile(string path, string newName)
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

    public void ShowFile(string path, string mode)
    {
        string absolutePath = Path.GetFullPath(path);
        const string KeyWordConsole = "console";

        if (File.Exists(absolutePath))
        {
            if (mode.Equals(KeyWordConsole, StringComparison.Ordinal))
            {
                string fileContent = File.ReadAllText(absolutePath);
                Console.WriteLine(fileContent);
            }
        }
    }

    public void TreeGoTo(string path)
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

    public void TreeList(int depth)
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