namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal
{
    using System.Net;

    /// <summary>
    /// Internal custom http request exception for Teams workload.
    /// </summary>
    internal class MGTeamsInternalServiceRequestException : MGTeamsInternalException
    {
        /// <summary>
        /// The Http status code of the error.
        /// </summary>
        internal HttpStatusCode HttpStatusCode { get; }

        /// <summary>
        /// The odata error.
        /// </summary>
        internal Models.IMicrosoftGraphODataErrorsOdataError ODataError { get; }

        /// <summary>
        /// Initializes a new instance of the MGTeamsInternalServiceRequestException class.
        /// </summary>
        /// <param name="httpStatusCode">The http status code.</param>
        /// <param name="odataError">The odata error.</param>
        internal MGTeamsInternalServiceRequestException(
            System.Net.HttpStatusCode httpStatusCode,
            Models.IMicrosoftGraphODataErrorsOdataError odataError) : base(MGTeamsInternalErrorType.ServiceRequestFailed, odataError?.Error?.Message)
        {
            this.HttpStatusCode = httpStatusCode;
            this.ODataError = odataError;
        }
    }
}