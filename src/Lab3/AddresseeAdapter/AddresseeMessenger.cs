using Itmo.ObjectOrientedProgramming.Lab3.Addresse;
using Itmo.ObjectOrientedProgramming.Lab3.LevelOfImportant;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class AddresseeMessenger : AddresseeBase
{
    private readonly Messenger _messenger = new(new ConsoleShowText());
    private readonly ILogger _logger;

    public AddresseeMessenger(ILogger logger)
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
            _logger.OutputText("Receive message");
            _messenger.WriteText(message);
        }
        else
        {
            _logger.OutputText("Doesnt received");
        }
    }
}