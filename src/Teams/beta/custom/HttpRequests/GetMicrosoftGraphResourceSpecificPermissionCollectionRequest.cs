namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal.Requests
{
    /// <summary>
    /// Request to get resource specific permissions for Microsoft Graph's service principal.
    /// </summary>
    internal class GetMicrosoftGraphResourceSpecificPermissionCollectionRequest : TeamsHttpRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrosoftGraphResourceSpecificPermissionCollectionRequest"/> class.
        /// </summary>
        internal GetMicrosoftGraphResourceSpecificPermissionCollectionRequest()
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
            return $"https://graph.microsoft.com/beta/serviceprincipals/appId=00000003-0000-0000-c000-000000000000/resourceSpecificApplicationPermissions";
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
