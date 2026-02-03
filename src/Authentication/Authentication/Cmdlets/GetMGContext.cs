// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.Management.Automation;

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, "MgContext", DefaultParameterSetName = Constants.UserParameterSet, HelpUri = "https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/get-mgcontext")]
    [OutputType(typeof(IAuthContext))]
    public class GetMgContext : PSCmdlet
    {
        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            IAuthContext authConfig = GraphSession.Instance.AuthContext;
            if (authConfig != null)
                WriteObject(authConfig);
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
