// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell
{
    using Microsoft.Graph.PowerShell.Authentication;
    using Microsoft.Graph.PowerShell.Authentication.Helpers;
    using Microsoft.Graph.PowerShell.Authentication.Models;
    using System;
    using System.Linq;
    using System.Management.Automation;
    using System.Management.Automation.Runspaces;

    public partial class Module
    {
        /// <summary>
        /// The selected Microsoft Graph profile.
        /// </summary>
        public string ProfileName { get; set; } = "v1.0-beta";
        partial void BeforeCreatePipeline(System.Management.Automation.InvocationInfo invocationInfo, ref Runtime.HttpPipeline pipeline)
        {
            pipeline = new Runtime.HttpPipeline(new Runtime.HttpClientFactory(HttpHelpers.GetGraphHttpClient()));
        }
    }
}
