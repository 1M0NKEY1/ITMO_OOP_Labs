namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.Strategy;

public interface IStrategy
{
    void Connect(string address, string mode);
    void Disconnect();
    void CopyFile(string sourcePath, string destinationPath);
    void DeleteFile(string path);
    void MoveFile(string sourcePath, string destinationPath);
    void RenameFile(string path, string newName);
    void ShowFile(string path, string mode);
    void TreeGoTo(string path);
    void TreeList(int depth);
}