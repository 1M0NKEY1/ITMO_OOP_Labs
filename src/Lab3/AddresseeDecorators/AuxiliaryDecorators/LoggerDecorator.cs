namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class LoggerDecorator : IAddressee
{
    private readonly IAddressee _addressee;
    private readonly ILogger _logger;

    public LoggerDecorator(IAddressee addressee, ILogger logger)
    {
        _addressee = addressee;
        _logger = logger;
    }

    public void ReceiveMessage(IMessage message)
    {
        _logger.OutputText("Received message");
        _addressee.ReceiveMessage(message);
    }
}