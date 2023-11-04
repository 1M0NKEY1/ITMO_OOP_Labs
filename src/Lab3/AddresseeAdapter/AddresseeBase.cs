using Itmo.ObjectOrientedProgramming.Lab3.LevelOfImportant;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public abstract class AddresseeBase
{
    protected AddresseeBase(ILogger logger)
    {
        Logger = logger;
    }

    public ILogger Logger { get; }

    public abstract bool FilterForLevel(LevelOfImportance levelOfImportance);
    public abstract void ReceiveMessage(IMessage message);
}