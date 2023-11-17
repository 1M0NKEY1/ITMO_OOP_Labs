using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public interface ICommandHandler
{
    void SetNextHandler(ICommandHandler? handler);
    void Handle(IList<string> parts);
}