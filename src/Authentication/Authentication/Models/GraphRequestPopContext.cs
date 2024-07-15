// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Identity;
using System;
using System.IO;
using System.Net.Http;

namespace Microsoft.Graph.PowerShell.Authentication
{
    internal class GraphRequestPopContext : IGraphRequestPopContext
    {
        public Uri Uri { get; set; }
        public HttpMethod HttpMethod { get; set; }
        public AccessToken AccessToken { get; set; }
        public HttpPipeline PopPipeline { get; set; }
        public InteractiveBrowserCredential PopInteractiveBrowserCredential { get; set; }
    }

}