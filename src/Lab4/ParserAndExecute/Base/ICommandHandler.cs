using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public interface ICommandHandler
{
    IList<ICommandHandler>? CommandHandlers { get; }
    void SetNextHandler(ICommandHandler handler);
    void Handle(IList<string> parts);
}