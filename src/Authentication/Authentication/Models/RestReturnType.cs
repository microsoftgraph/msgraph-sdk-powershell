namespace Microsoft.Graph.PowerShell.Authentication.Models
{
    public enum RestReturnType
    {
        /// <summary>
        ///     Return type not defined in response,
        ///     best effort detect.
        /// </summary>
        Detect = 0,

        /// <summary>
        ///     Json return type.
        /// </summary>
        Json = 1,

        /// <summary>
        ///     Xml return type.
        /// </summary>
        Xml = 2
    }
}