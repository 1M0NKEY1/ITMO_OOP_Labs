using System;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class ConnectToFileCommand : CommandHandlerBase
{
    private readonly string _address;
    private readonly string _mode;

    public ConnectToFileCommand(string address, string mode)
    {
        _address = address;
        _mode = mode;
    }

    public override void HandleRequest(Request request)
    {
        if (_mode.Equals("local", StringComparison.OrdinalIgnoreCase))
        {
            if (File.Exists(_address))
            {
                Directory.SetCurrentDirectory(_address);
            }
        }
    }
}