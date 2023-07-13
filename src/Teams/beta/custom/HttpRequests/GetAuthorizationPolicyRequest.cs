namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal.Requests
{
    /// <summary>
    /// Request to get authorization policy.
    /// </summary>
    internal class GetAuthorizationPolicyRequest : TeamsHttpRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthorizationPolicyRequest"/> class.
        /// </summary>
        internal GetAuthorizationPolicyRequest()
        {
        }

        /// <summary>
        /// Gets the Http method for the request.
        /// </summary>
        /// <returns>The http method.</returns>
        protected override System.Net.Http.HttpMethod GetHttpMethod()
        {
            return Runtime.Method.Get;
        }

        /// <summary>
        /// Gets the base url for the request.
        /// </summary>
        /// <returns>string containing the base url.</returns>
        protected override string GetBaseUrl()
        {
            return $"https://graph.microsoft.com/v1.0/policies/authorizationPolicy";
        }

        /// <summary>
        /// Gets the body of the request as a string.
        /// </summary>
        /// <returns>The body.</returns>
        protected override string GetBodyAsString()
        {
            return null;
        }
    }
}
