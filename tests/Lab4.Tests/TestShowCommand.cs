using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Requests;
using Itmo.ObjectOrientedProgramming.Lab4.Tests.Moqs;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab4.Tests;

public class TestShowCommand
{
    private const string InputString = @"file show C:\Users\Egor\OneDrive\Документы\Test.txt -m console";
    private const string OutputExpectedText = "a";

    public static IEnumerable<object[]> GetObjects
    {
        get
        {
            yield return new object[]
            {
                InputString,
                new ParseConnectCommand(),
                new ParseDisconnectCommand(),
                new ParseCopyFileCommand(),
                new ParseDeleteFileCommand(),
                new ParseMoveFileCommand(),
                new ParseRenameFileCommand(),
                new ParseTreeGotoCommand(),
                new ParseTreeListCommand(),
            };
        }
    }

    [Theory]
    [MemberData(nameof(GetObjects))]
    public void AllObjectsAreOddWithMemberDataFromDataGenerator(
        string inputString,
        ParseConnectCommand? parseConnectCommand,
        ParseDisconnectCommand? parseDisconnectCommand,
        ParseCopyFileCommand? parseCopyFileCommand,
        ParseDeleteFileCommand? parseDeleteFileCommand,
        ParseMoveFileCommand? parseMoveFileCommand,
        ParseRenameFileCommand? parseRenameFileCommand,
        ParseTreeGotoCommand? parseTreeGotoCommand,
        ParseTreeListCommand? parseTreeListCommand)
    {
        var handler = new TestShowMoq();

        parseConnectCommand?.SetNextHandler(parseDisconnectCommand);
        parseDisconnectCommand?.SetNextHandler(parseCopyFileCommand);
        parseCopyFileCommand?.SetNextHandler(parseDeleteFileCommand);
        parseDeleteFileCommand?.SetNextHandler(parseMoveFileCommand);
        parseMoveFileCommand?.SetNextHandler(parseRenameFileCommand);
        parseRenameFileCommand?.SetNextHandler(handler);
        handler.SetNextHandler(parseTreeGotoCommand);
        parseTreeGotoCommand?.SetNextHandler(parseTreeListCommand);
        parseTreeListCommand?.SetNextHandler(parseConnectCommand);

        var request = new Request(inputString);
        IList<string> splitString = request.SplitString();

        parseConnectCommand?.Handle(splitString);
        var testShowMoq = (TestShowMoq)handler;
        Assert.Equal(OutputExpectedText, testShowMoq.GetInnerFile);
    }
}