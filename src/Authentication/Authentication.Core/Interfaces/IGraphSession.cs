// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Azure.Core;
using Microsoft.Graph.PowerShell.Authentication.Core.Interfaces;
using System.Collections.Concurrent;

namespace Microsoft.Graph.PowerShell.Authentication.Interfaces
{
    public interface IGraphSession
    {
        IAuthContext AuthContext { get; set; }
        IDataStore DataStore { get; set; }
        IRequestContext RequestContext { get; set; }
        IGraphOption GraphOption { get; set; }

        /// <summary>
        /// Caches the last acquired <see cref="AccessToken"/> per scope set so that
        /// <c>Get-MgAccessToken</c> can reuse a cached token until it is close to expiry.
        /// </summary>
        ConcurrentDictionary<string, AccessToken> AccessTokenCache { get; }
    }
}