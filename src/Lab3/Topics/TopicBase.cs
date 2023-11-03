using Itmo.ObjectOrientedProgramming.Lab3.Addressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.TopicDir;

public abstract class TopicBase
{
    public abstract string TopicName { get; }
    public abstract AddresseeBase Addressee { get; }
}