using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public interface ICommandHandler
{
    void SetNextHandler(ICommandHandler? handler);
    ICommand? Handle(IList<string> parts);
}