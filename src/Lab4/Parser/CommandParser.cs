using System;
using System.Text.RegularExpressions;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class CommandParser
{
    public void ParseCommand(string input)
    {
        if (TryParseConnectCommand(input, out string address, out string mode))
        {
            return new ConnectCommand(address, mode);
        }
        else if (TryParseDisconnectCommand(input))
        {
            return new DisconnectCommand();
        }
        else if (TryParseTreeGotoCommand(input, out string path))
        {
            return new TreeGotoCommand(path);
        }
        else if (TryParseTreeListCommand(input, out int depth))
        {
            return new TreeListCommand(depth);
        }
        else if (TryParseFileShowCommand(input, out string filePath, out string fileMode))
        {
            return new FileShowCommand(filePath, fileMode);
        }
        else if (TryParseFileMoveCommand(input, out string sourcePath, out string destinationPath))
        {
            return new FileMoveCommand(sourcePath, destinationPath);
        }
        else if (TryParseFileCopyCommand(input, out sourcePath, out destinationPath))
        {
            return new FileCopyCommand(sourcePath, destinationPath);
        }
        else if (TryParseFileDeleteCommand(input, out string path))
        {
            return new FileDeleteCommand(path);
        }
        else if (TryParseFileRenameCommand(input, out path, out string newName))
        {
            return new FileRenameCommand(path, newName);
        }
        else
        {
            throw new ArgumentException("Invalid command.");
        }
    }

    


    private bool TryParseDisconnectCommand(string input)
    {
        return input.Equals("disconnect", StringComparison.OrdinalIgnoreCase);
    }

    private bool TryParseTreeGotoCommand(string input, out string path)
    {
        path = null;
        var regex = new Regex(@"^tree\s+goto\s+(\S+)$");
        Match match = regex.Match(input);
        if (match.Success)
        {
            path = match.Groups[1].Value;
            return true;
        }

        return false;
    }

    private bool TryParseTreeListCommand(string input, out int depth)
    {
        depth = 0;
        var regex = new Regex(@"^tree\s+list\s+-d\s+(\d+)$");
        Match match = regex.Match(input);
        if (match.Success)
        {
            if (int.TryParse(match.Groups[1].Value, out depth))
            {
                return true;
            }
        }

        return false;
    }

    private bool TryParseFileShowCommand(string input, out string path, out string mode)
    {
        path = null;
        mode = null;
        var regex = new Regex(@"^file\s+show\s+(\S+)\s*(-m\s+(\S+))?$");
        Match match = regex.Match(input);
        if (match.Success)
        {
            path = match.Groups[1].Value;
            mode = match.Groups[3].Success ? match.Groups[3].Value : "default";
            return true;
        }

        return false;
    }

    private bool TryParseFileMoveCommand(string input, out string sourcePath, out string destinationPath)
    {
        sourcePath = null;
        destinationPath = null;
        var regex = new Regex(@"^file\s+move\s+(\S+)\s+(\S+)$");
        Match match = regex.Match(input);
        if (match.Success)
        {
            sourcePath = match.Groups[1].Value;
            destinationPath = match.Groups[2].Value;
            return true;
        }

        return false;
    }

    private bool TryParseFileCopyCommand(string input, out string sourcePath, out string destinationPath)
    {
        sourcePath = null;
        destinationPath = null;
        var regex = new Regex(@"^file\s+copy\s+(\S+)\s+(\S+)$");
        Match match = regex.Match(input);
        if (match.Success)
        {
            sourcePath = match.Groups[1].Value;
            destinationPath = match.Groups[2].Value;
            return true;
        }

        return false;
    }

    private bool TryParseFileDeleteCommand(string input, out string path)
    {
        path = null;
        var regex = new Regex(@"^file\s+delete\s+(\S+)$");
        Match match = regex.Match(input);
        if (match.Success)
        {
            path = match.Groups[1].Value;
            return true;
        }

        return false;
    }

    private bool TryParseFileRenameCommand(string input, out string path, out string newName)
    {
        path = null;
        newName = null;
        var regex = new Regex(@"^file\s+rename\s+(\S+)\s+(\S+)$");
        Match match = regex.Match(input);
        if (match.Success)
        {
            path = match.Groups[1].Value;
            newName = match.Groups[2].Value;
            return true;
        }

        return false;
    }
}
