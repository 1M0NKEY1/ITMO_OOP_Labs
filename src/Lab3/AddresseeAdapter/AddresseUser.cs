using Itmo.ObjectOrientedProgramming.Lab3.Addresse;
using Itmo.ObjectOrientedProgramming.Lab3.LevelOfImportant;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class AddresseUser : AddresseeBase
{
    private readonly User _user = new();
    private readonly ILogger _logger;

    public AddresseUser(ILogger logger)
        : base(logger)
    {
        _logger = logger;
    }

    public override bool FilterForLevel(LevelOfImportance levelOfImportance)
    {
        return levelOfImportance switch
        {
            HighLevelOfImportance or MiddleLevelOfImportance => true,
            _ => false,
        };
    }

    public override void ReceiveMessage(IMessage message)
    {
        if (message.LevelOfImportance != null && FilterForLevel(message.LevelOfImportance))
        {
            _logger.OutputText("Received message");
            _user.SaveMessage(message);
        }

        _logger.OutputText("Doesnt received");
    }

    public void ChangedMessageStatus(IMessage message)
    {
        _user.ChangeStatus(message);
    }

    public bool FindMessageStatus(IMessage message)
    {
        return _user.ListOfUnreadMessages.Contains(message);
    }
}