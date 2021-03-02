// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    using Microsoft.Graph.PowerShell.Authentication.Cmdlets;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Reflection;
    using System.Security.Authentication;
    using Microsoft.Graph.PowerShell.Authentication.Handlers;

    /// <summary>
    /// A HTTP helper class.
    /// </summary>
    public static class HttpHelpers
    {
        /// The version for current assembly.
        private static AssemblyName AssemblyInfo = typeof(ConnectMgGraph).GetTypeInfo().Assembly.GetName();

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
        /// <param name="authContext"></param>
        /// <returns></returns>
        public static HttpClient GetGraphHttpClient(IAuthContext authContext = null)
        {
            authContext = authContext ?? GraphSession.Instance.AuthContext;
            if (authContext is null)
            {
                throw new AuthenticationException(Core.ErrorConstants.Message.MissingAuthContext);
            }

            IAuthenticationProvider authProvider = AuthenticationHelpers.GetAuthProvider(authContext);
            return GetGraphHttpClient(authProvider);
        }

        /// <summary>
        /// Prepend new SDKVersionHeaders
        /// </summary>
        /// <param name="httpClient"></param>
        private static void PrependNewSDKVersionHeaders(HttpClient httpClient)
        {
            IEnumerable<string> previousSDKHeaders = httpClient.DefaultRequestHeaders.GetValues(CoreConstants.Headers.SdkVersionHeaderName);
            httpClient.DefaultRequestHeaders.Remove(CoreConstants.Headers.SdkVersionHeaderName);
            httpClient.DefaultRequestHeaders.Add(
                CoreConstants.Headers.SdkVersionHeaderName,
                previousSDKHeaders.Prepend(AuthModuleVersionHeaderValue));
        }

        /// <summary>
        /// Creates a pre-configured Microsoft Graph <see cref="HttpClient"/>.
        /// with an <see cref="IAuthenticationProvider"/>
        /// </summary>
        /// <param name="authProvider">Custom AuthProvider</param>
        /// <returns></returns>
        public static HttpClient GetGraphHttpClient(IAuthenticationProvider authProvider)
        {
            IList<DelegatingHandler> defaultHandlers = GraphClientFactory.CreateDefaultHandlers(authProvider);

            // Register NationalCloudHandler after AuthHandler.
            defaultHandlers.Insert(1, new NationalCloudHandler());
            // Register ODataQueryOptionsHandler after NationalCloudHandler.
            defaultHandlers.Insert(2, new ODataQueryOptionsHandler());

            HttpClient httpClient = GraphClientFactory.Create(defaultHandlers);

            // Prepend new SDKVersionHeaders
            PrependNewSDKVersionHeaders(httpClient);
            return httpClient;
        }
    }
}
