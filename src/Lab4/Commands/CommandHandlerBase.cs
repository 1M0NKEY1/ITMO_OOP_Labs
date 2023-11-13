namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public abstract class CommandHandlerBase
{
    private CommandHandlerBase? nextHandler;

    public void SetNextCommandHandler(CommandHandlerBase handler)
    {
        nextHandler = handler;
    }

    public abstract void HandleRequest(Request request);

    protected void PassRequestToNextHandler(Request request)
    {
        if (nextHandler != null)
        {
            nextHandler.HandleRequest(request);
        }
    }
}