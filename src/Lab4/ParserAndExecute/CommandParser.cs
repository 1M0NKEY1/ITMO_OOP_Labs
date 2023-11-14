using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public abstract class CommandParser
{
    protected IList<ICommandHandler> CommandHandlers { get; } = new List<ICommandHandler>();

    public void AddCommandHandler(ICommandHandler commandHandler)
    {
        CommandHandlers.Add(commandHandler);
    }
}
