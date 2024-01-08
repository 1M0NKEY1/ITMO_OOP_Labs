using Itmo.ObjectOrientedProgramming.Lab3.LevelOfImportant;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class FilterDecorator : IAddressee
{
    private readonly IAddressee _addressee;
    private readonly LevelOfImportance _levelOfImportance;

    public FilterDecorator(IAddressee addressee, LevelOfImportance levelOfImportance)
    {
        _addressee = addressee;
        _levelOfImportance = levelOfImportance;
    }

    public void ReceiveMessage(IMessage message)
    {
        if (message.LevelOfImportance == _levelOfImportance)
        {
            _addressee.ReceiveMessage(message);
        }
    }
}