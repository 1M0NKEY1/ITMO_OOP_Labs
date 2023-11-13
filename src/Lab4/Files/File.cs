namespace Itmo.ObjectOrientedProgramming.Lab4.Files;

public class File : IFile
{
    public File(string name, string path)
    {
        Name = name;
        Path = path;
    }

    public string Name { get; }
    public string Path { get; }
}