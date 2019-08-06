// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.Common
{
    using Microsoft.Graph;
    using Microsoft.Graph.Common.Models;
    using System.Net.Http;
    public static class Common
    {
        /// <summary>
        /// Creates a Microsoft Graph aware <see cref="HttpClient"/>.
        /// </summary>
        /// <returns>A <see cref="HttpClient"/> instance.</returns>
        public static HttpClient GetGraphHttpClient(AuthConfig authConfig)
        {
            return GraphClientFactory.Create(Authentication.Authentication.GetAuthProvider(authConfig));
        }
    }
}
