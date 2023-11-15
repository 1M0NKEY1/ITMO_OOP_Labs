namespace Itmo.ObjectOrientedProgramming.Lab4;

public class Parser
{
    private readonly ParseConnectCommand? _parseConnectCommand;
    private readonly ParseDisconnectCommand? _parseDisconnectCommand;
    private readonly ParseCopyFileCommand? _parseCopyFileCommand;
    private readonly ParseDeleteFileCommand? _parseDeleteFileCommand;
    private readonly ParseMoveFileCommand? _parseMoveFileCommand;
    private readonly ParseRenameFileCommand? _parseRenameFileCommand;
    private readonly ParseShowFileCommand? _parseShowFileCommand;
    private readonly ParseTreeGotoCommand? _parseTreeGotoCommand;
    private readonly ParseTreeListCommand? _parseTreeListCommand;

    public Parser(
        ParseConnectCommand? parseConnectCommand,
        ParseDisconnectCommand? parseDisconnectCommand,
        ParseCopyFileCommand? parseCopyFileCommand,
        ParseDeleteFileCommand? parseDeleteFileCommand,
        ParseMoveFileCommand? parseMoveFileCommand,
        ParseRenameFileCommand? parseRenameFileCommand,
        ParseShowFileCommand? parseShowFileCommand,
        ParseTreeGotoCommand? parseTreeGotoCommand,
        ParseTreeListCommand? parseTreeListCommand)
    {
        _parseConnectCommand = parseConnectCommand;
        _parseDisconnectCommand = parseDisconnectCommand;
        _parseCopyFileCommand = parseCopyFileCommand;
        _parseDeleteFileCommand = parseDeleteFileCommand;
        _parseMoveFileCommand = parseMoveFileCommand;
        _parseRenameFileCommand = parseRenameFileCommand;
        _parseShowFileCommand = parseShowFileCommand;
        _parseTreeGotoCommand = parseTreeGotoCommand;
        _parseTreeListCommand = parseTreeListCommand;
    }
}