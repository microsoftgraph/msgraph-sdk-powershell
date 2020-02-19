// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    using Microsoft.Graph.Auth;
    using Microsoft.Graph.PowerShell.Authentication.Helpers;
    using Microsoft.Graph.PowerShell.Authentication.Models;
    using System;
    using System.Collections.Generic;
    using System.Management.Automation;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    [Cmdlet(VerbsCommon.Get, "MgContext", DefaultParameterSetName = Constants.UserParameterSet)]
    [OutputType(typeof(AuthConfig))]
    public class GetMGContext: PSCmdlet
    {
        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            // Get auth config from session state.
            PSVariable graphAuthVariable = SessionState.PSVariable.Get(Constants.GraphAuthConfigId);
            AuthConfig authConfig = graphAuthVariable?.Value as AuthConfig;
            Invoke<AuthConfig>();
            WriteObject(authConfig as AuthConfig);
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
        }
    }
}
