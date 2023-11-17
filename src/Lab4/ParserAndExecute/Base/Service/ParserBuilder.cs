namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParserBuilder : IParserBuilder
{
    private ParseConnectCommand? _parseConnectCommand;
    private ParseDisconnectCommand? _parseDisconnectCommand;
    private ParseCopyFileCommand? _parseCopyFileCommand;
    private ParseDeleteFileCommand? _parseDeleteFileCommand;
    private ParseMoveFileCommand? _parseMoveFileCommand;
    private ParseRenameFileCommand? _parseRenameFileCommand;
    private ParseShowFileCommand? _parseShowFileCommand;
    private ParseTreeGotoCommand? _parseTreeGotoCommand;
    private ParseTreeListCommand? _parseTreeListCommand;

    public Parser Create()
    {
        return new Parser(
            _parseConnectCommand,
            _parseDisconnectCommand,
            _parseCopyFileCommand,
            _parseDeleteFileCommand,
            _parseMoveFileCommand,
            _parseRenameFileCommand,
            _parseShowFileCommand,
            _parseTreeGotoCommand,
            _parseTreeListCommand);
    }

    public void SetChainOfCommands()
    {
        _parseConnectCommand?.SetNextHandler(_parseDisconnectCommand);
        _parseDisconnectCommand?.SetNextHandler(_parseCopyFileCommand);
        _parseCopyFileCommand?.SetNextHandler(_parseDeleteFileCommand);
        _parseDeleteFileCommand?.SetNextHandler(_parseMoveFileCommand);
        _parseMoveFileCommand?.SetNextHandler(_parseRenameFileCommand);
        _parseRenameFileCommand?.SetNextHandler(_parseShowFileCommand);
        _parseShowFileCommand?.SetNextHandler(_parseTreeGotoCommand);
        _parseTreeGotoCommand?.SetNextHandler(_parseTreeListCommand);
        _parseTreeListCommand?.SetNextHandler(_parseConnectCommand);
    }

    public IParserBuilder WithParseConnectCommand(ParseConnectCommand? parseConnectCommand)
    {
        _parseConnectCommand = parseConnectCommand;
        return this;
    }

    public IParserBuilder WithParseDisconnectCommand(ParseDisconnectCommand? parseDisconnectCommand)
    {
        _parseDisconnectCommand = parseDisconnectCommand;
        return this;
    }

    public IParserBuilder WithParseCopyFileCommand(ParseCopyFileCommand? parseCopyFileCommand)
    {
        _parseCopyFileCommand = parseCopyFileCommand;
        return this;
    }

    public IParserBuilder WithParseDeleteFileCommand(ParseDeleteFileCommand? parseDeleteFileCommand)
    {
        _parseDeleteFileCommand = parseDeleteFileCommand;
        return this;
    }

    public IParserBuilder WithParseMoveFileCommand(ParseMoveFileCommand? parseMoveFileCommand)
    {
        _parseMoveFileCommand = parseMoveFileCommand;
        return this;
    }

    public IParserBuilder WithParseRenameFileCommand(ParseRenameFileCommand? parseRenameFileCommand)
    {
        _parseRenameFileCommand = parseRenameFileCommand;
        return this;
    }

    public IParserBuilder WithParseShowFileCommand(ParseShowFileCommand? parseShowFileCommand)
    {
        _parseShowFileCommand = parseShowFileCommand;
        return this;
    }

    public IParserBuilder WithParseTreeGotoCommand(ParseTreeGotoCommand? parseTreeGotoCommand)
    {
        _parseTreeGotoCommand = parseTreeGotoCommand;
        return this;
    }

    public IParserBuilder WithParseTreeListCommand(ParseTreeListCommand? parseTreeListCommand)
    {
        _parseTreeListCommand = parseTreeListCommand;
        return this;
    }
}