// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Azure.Core;
using Azure.Identity;
using System;
using System.Net.Http;

namespace Microsoft.Graph.PowerShell.Authentication
{
    public interface IGraphRequestProofofPossession
    {
        Uri Uri { get; set; }
        HttpMethod HttpMethod { get; set; }
        AccessToken AccessToken { get; set; }
        string ProofofPossessionNonce { get; set; }
        PopTokenRequestContext PopTokenContext { get; set; }
        Request Request { get; set; }
        InteractiveBrowserCredential BrowserCredential { get; set; }
    }
}