namespace Itmo.ObjectOrientedProgramming.Lab4;

public interface IParserBuilder
{
    Parser Create();
    IParserBuilder WithParseConnectCommand(ParseConnectCommand? parseConnectCommand);
    IParserBuilder WithParseDisconnectCommand(ParseDisconnectCommand? parseDisconnectCommand);
    IParserBuilder WithParseCopyFileCommand(ParseCopyFileCommand? parseCopyFileCommand);
    IParserBuilder WithParseDeleteFileCommand(ParseDeleteFileCommand? parseDeleteFileCommand);
    IParserBuilder WithParseMoveFileCommand(ParseMoveFileCommand? parseMoveFileCommand);
    IParserBuilder WithParseRenameFileCommand(ParseRenameFileCommand? parseRenameFileCommand);
    IParserBuilder WithParseShowFileCommand(ParseShowFileCommand? parseShowFileCommand);
    IParserBuilder WithParseTreeGotoCommand(ParseTreeGotoCommand? parseTreeGotoCommand);
    IParserBuilder WithParseTreeListCommand(ParseTreeListCommand? parseTreeListCommand);
}