using System;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class ConnectCommand : ICommand
{
    private const string KeyWordThree = "local";
    private readonly string _address;
    private readonly string _mode;

    public ConnectCommand(string address, string mode)
    {
        _address = address;
        _mode = mode;
    }

    public void Execute()
    {
        if (_mode.Equals(KeyWordThree, StringComparison.Ordinal))
        {
            var fileInfo = new FileInfo(_address);

            if (fileInfo is { Exists: true, Directory.Exists: true })
            {
                Console.WriteLine($"Connect to local file system: '{fileInfo.FullName}'");
            }
        }
    }
}