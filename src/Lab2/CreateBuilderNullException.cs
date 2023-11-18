using System;

namespace Itmo.ObjectOrientedProgramming.Lab2;

public class CreateBuilderNullException : ArgumentNullException
{
    public CreateBuilderNullException()
        : base()
    {
    }

    public CreateBuilderNullException(string paramName)
        : base(paramName)
    {
    }

    public CreateBuilderNullException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public CreateBuilderNullException(string paramName, string message)
        : base(paramName, message)
    {
    }
}