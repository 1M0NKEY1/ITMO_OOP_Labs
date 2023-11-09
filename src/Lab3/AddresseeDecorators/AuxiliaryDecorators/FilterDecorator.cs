using Itmo.ObjectOrientedProgramming.Lab3.LevelOfImportant;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class FilterDecorator : AddresseeBase
{
    private readonly AddresseeBase _addresseeBase;
    private readonly LevelOfImportance _levelOfImportance;

    public FilterDecorator(AddresseeBase addresseeBase, LevelOfImportance levelOfImportance)
    {
        _addresseeBase = addresseeBase;
        _levelOfImportance = levelOfImportance;
    }

    public override void ReceiveMessage(IMessage message)
    {
        if (message.LevelOfImportance == _levelOfImportance)
        {
            _addresseeBase.ReceiveMessage(message);
        }
    }
}