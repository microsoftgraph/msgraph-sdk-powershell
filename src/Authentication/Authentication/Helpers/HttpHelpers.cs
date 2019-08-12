// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    using Microsoft.Graph.PowerShell.Authentication.Models;
    using System.Net.Http;
    /// <summary>
    /// A HTTP helper class.
    /// </summary>
    public static class HttpHelpers
    {
        /// <summary>
        /// Creates a pre-configured Microsoft Graph <see cref="HttpClient"/>.
        /// </summary>
        /// <param name="authConfig"></param>
        /// <returns></returns>
        public static HttpClient GetGraphHttpClient(AuthConfig authConfig)
        {
            IAuthenticationProvider authProvider = AuthenticationHelpers.GetAuthProvider(authConfig);
            return GraphClientFactory.Create(authProvider);
        }
    }
}
