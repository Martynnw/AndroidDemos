using System;
using System.Diagnostics.Contracts;
namespace LoggingDemo
{
    public interface ILogManager
    {
        ILogger GetLog([System.Runtime.CompilerServices.CallerFilePath]string callerFilePath = "");
    }
}
