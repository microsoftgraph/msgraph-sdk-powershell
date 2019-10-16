// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    using Microsoft.Graph.PowerShell.Authentication.Cmdlets;
    using Microsoft.Graph.PowerShell.Authentication.Models;
    using System.Net.Http;
    using System.Reflection;

    /// <summary>
    /// A HTTP helper class.
    /// </summary>
    public static class HttpHelpers
    {
        /// The version for current assembly.
        private static AssemblyName AssemblyInfo = typeof(ConnectGraph).GetTypeInfo().Assembly.GetName();

        /// The value for the Auth module version header.
        private static string AuthModuleVersionHeaderValue =
            string.Format(Constants.SDKHeaderValue,
                AssemblyInfo.Name,
                AssemblyInfo.Version.Major,
                AssemblyInfo.Version.Minor,
                AssemblyInfo.Version.Build);

        /// <summary>
        /// Creates a pre-configured Microsoft Graph <see cref="HttpClient"/>.
        /// </summary>
        /// <param name="authConfig"></param>
        /// <returns></returns>
        public static HttpClient GetGraphHttpClient(AuthConfig authConfig)
        {
            IAuthenticationProvider authProvider = AuthenticationHelpers.GetAuthProvider(authConfig);
            HttpClient httpClient = GraphClientFactory.Create(authProvider);
            httpClient.DefaultRequestHeaders.Add(CoreConstants.Headers.SdkVersionHeaderName, AuthModuleVersionHeaderValue);
            return httpClient;
        }
    }
}
