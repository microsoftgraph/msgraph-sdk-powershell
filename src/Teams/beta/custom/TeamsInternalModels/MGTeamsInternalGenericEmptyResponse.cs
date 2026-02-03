namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal
{
    using System;

    /// <summary>
    /// Class representing a generic empty http response.
    /// </summary>
    internal class MGTeamsInternalGenericEmptyResponse
    {
        /// <summary>
        /// Lazy singleton instance for this class.
        /// </summary>
        internal static Lazy<MGTeamsInternalGenericEmptyResponse> LazyInstance { get; } =
            new Lazy<MGTeamsInternalGenericEmptyResponse>(System.Threading.LazyThreadSafetyMode.PublicationOnly);
    }
}
