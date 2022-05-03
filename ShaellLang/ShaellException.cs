using System;

namespace ShaellLang;

public class ShaellException : Exception
{
    public IValue ExceptionValue { get; }
    public int ErrorCode { get; }
    
    public ShaellException(IValue exceptionValue, int errorCode = 1)
    {
        ExceptionValue = exceptionValue;
        ErrorCode = errorCode;
    }

    public override string ToString()
    {
        return $"Uncaught Shaell Exception:\n{ExceptionValue}";
    }
}