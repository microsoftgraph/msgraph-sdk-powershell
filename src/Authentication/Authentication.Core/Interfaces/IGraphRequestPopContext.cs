// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Identity;
using System;
using System.Net.Http;

namespace Microsoft.Graph.PowerShell.Authentication
{
    public interface IGraphRequestPopContext
    {
        Uri Uri { get; set; }
        HttpMethod HttpMethod { get; set; }
        AccessToken AccessToken { get; set; }
        HttpPipeline PopPipeline { get; set; }
        InteractiveBrowserCredential PopInteractiveBrowserCredential { get; set; }
    }
}