namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class LoggerDecorator : AddresseeBase
{
    private readonly AddresseeBase _addresseeBase;
    private readonly ILogger _logger;

    public LoggerDecorator(AddresseeBase addresseeBase, ILogger logger)
    {
        _addresseeBase = addresseeBase;
        _logger = logger;
    }

    public override void ReceiveMessage(IMessage message)
    {
        _logger.OutputText("Received message");
        _addresseeBase.ReceiveMessage(message);
    }
}