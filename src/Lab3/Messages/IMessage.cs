using Itmo.ObjectOrientedProgramming.Lab3.LevelOfImportant;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public interface IMessage
{
    public string? Heading { get; }
    public string? Body { get; }
    public LevelOfImportance? LevelOfImportance { get; }
}