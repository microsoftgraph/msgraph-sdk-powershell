using System;

namespace Microsoft.Graph.PowerShell.Authentication
{
    public interface IPSGraphOutputWriter
    {
        Action<string> WriteObject { get; set; }
        Action<string> WriteDebug { get; set; }
        Action<Exception, string, int, object> WriteError { get; set; }
        Action<object, string> WriteInformation { get; set; }
        Action<string> WriteVerbose { get; set; }
    }
}