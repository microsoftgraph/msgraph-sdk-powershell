// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph
{
    using Microsoft.Graph.Common;
    using Microsoft.Graph.Common.Models;
    using System;
    using System.Linq;
    using System.Management.Automation;
    using System.Management.Automation.Runspaces;

    public partial class Module
    {
        partial void BeforeCreatePipeline(System.Management.Automation.InvocationInfo invocationInfo, ref Runtime.HttpPipeline pipeline)
        {
            using (var powershell = PowerShell.Create(RunspaceMode.CurrentRunspace))
            {
                powershell.Commands.AddCommand(new Command($"$executioncontext.SessionState.PSVariable.GetValue('{Constants.GraphAuthConfigId}')", true));

                AuthConfig authConfig = powershell.Invoke<AuthConfig>().FirstOrDefault();

                if (authConfig == null)
                    throw new Exception("Authentication needed, call Connect-Graph.");

                pipeline = new Runtime.HttpPipeline(new Runtime.HttpClientFactory(Common.Common.GetGraphHttpClient(authConfig)));
            }
        }

        // CustomInit
    }
}
