// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Azure.Core;
using Azure.Identity;
using System;
using System.IO;
using System.Net.Http;

namespace Microsoft.Graph.PowerShell.Authentication
{
    internal class GraphRequestProofofPossession : IGraphRequestProofofPossession
    {
        public Uri Uri { get; set; }
        public HttpMethod HttpMethod { get; set; }
        public AccessToken AccessToken { get; set; }
        public string ProofofPossessionNonce { get; set; }
        public PopTokenRequestContext PopTokenContext { get; set; }
        public Request Request { get; set; }
        public InteractiveBrowserCredential BrowserCredential { get; set; }
    }

}