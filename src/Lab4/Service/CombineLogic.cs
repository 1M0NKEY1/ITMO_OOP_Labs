﻿using System;
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
        var config = new Config();

        while (true)
        {
            string? input = Console.ReadLine();
            if (input is not null)
            {
                IList<string> request = new Request(input).SplitString();
                ICommand? command = config.CreateParseConnectCommand().Handle(request);
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