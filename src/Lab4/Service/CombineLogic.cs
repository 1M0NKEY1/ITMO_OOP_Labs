using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.Strategy;
using Itmo.ObjectOrientedProgramming.Lab4.Requests;

namespace Itmo.ObjectOrientedProgramming.Lab4.Service;

public static class CombineLogic
{
    private static IStrategy? strategy;
    public static void Main()
    {
        const string mode = "local";
        var parseConnectCommand = new ParseConnectCommand();
        var parseDisconnectCommand = new ParseDisconnectCommand();
        var parseCopyFileCommand = new ParseCopyFileCommand();
        var parseDeleteFileCommand = new ParseDeleteFileCommand();
        var parseMoveFileCommand = new ParseMoveFileCommand();
        var parseRenameFileCommand = new ParseRenameFileCommand();
        var parseShowFileCommand = new ParseShowFileCommand();
        var parseTreeGotoCommand = new ParseTreeGotoCommand();
        var parseTreeListCommand = new ParseTreeListCommand();

        parseConnectCommand.SetNextHandler(parseDisconnectCommand);
        parseDisconnectCommand.SetNextHandler(parseCopyFileCommand);
        parseCopyFileCommand.SetNextHandler(parseDeleteFileCommand);
        parseDeleteFileCommand.SetNextHandler(parseMoveFileCommand);
        parseMoveFileCommand.SetNextHandler(parseRenameFileCommand);
        parseRenameFileCommand.SetNextHandler(parseShowFileCommand);
        parseShowFileCommand.SetNextHandler(parseTreeGotoCommand);
        parseTreeGotoCommand.SetNextHandler(parseTreeListCommand);
        parseTreeListCommand.SetNextHandler(parseConnectCommand);

        while (true)
        {
            string? input = Console.ReadLine();
            if (input is not null)
            {
                IList<string> request = new Request(input).SplitString();
                ICommand? command = parseConnectCommand.Handle(request);
                if (command is ConnectCommand)
                {
                    if (((ConnectCommand)command).Mode.Equals(mode, StringComparison.Ordinal))
                    {
                        strategy = new CommandStrategy();
                    }
                }

                if (strategy != null) command?.ChangeStrategy(strategy);
                command?.Execute();
            }
        }
    }
}