namespace Itmo.ObjectOrientedProgramming.Lab4.Service;

public class Config
{
    private readonly ParseConnectCommand _parseConnectCommand = new();
    private readonly ParseDisconnectCommand _parseDisconnectCommand = new();
    private readonly ParseCopyFileCommand _parseCopyFileCommand = new();
    private readonly ParseDeleteFileCommand _parseDeleteFileCommand = new();
    private readonly ParseMoveFileCommand _parseMoveFileCommand = new();
    private readonly ParseRenameFileCommand _parseRenameFileCommand = new();
    private readonly ParseShowFileCommand _parseShowFileCommand = new();
    private readonly ParseTreeGotoCommand _parseTreeGotoCommand = new();
    private readonly ParseTreeListCommand _parseTreeListCommand = new();

    public ParseConnectCommand CreateParseConnectCommand()
    {
        _parseConnectCommand.SetNextHandler(_parseDisconnectCommand);
        _parseDisconnectCommand.SetNextHandler(_parseCopyFileCommand);
        _parseCopyFileCommand.SetNextHandler(_parseDeleteFileCommand);
        _parseDeleteFileCommand.SetNextHandler(_parseMoveFileCommand);
        _parseMoveFileCommand.SetNextHandler(_parseRenameFileCommand);
        _parseRenameFileCommand.SetNextHandler(_parseShowFileCommand);
        _parseShowFileCommand.SetNextHandler(_parseTreeGotoCommand);
        _parseTreeGotoCommand.SetNextHandler(_parseTreeListCommand);
        _parseTreeListCommand.SetNextHandler(_parseConnectCommand);

        return _parseConnectCommand;
    }
}