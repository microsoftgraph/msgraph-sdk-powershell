// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    using Microsoft.Graph.PowerShell.Authentication.Helpers;
    using System;
    using System.Management.Automation;
    [Cmdlet(VerbsCommunications.Disconnect, "MgGraph")]
    [Alias("Disconnect-Graph")]
    public class DisconnectMgGraph : PSCmdlet
    {
        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            IAuthContext authConfig = GraphSession.Instance.AuthContext;

            if (authConfig == null)
                ThrowTerminatingError(
                    new ErrorRecord(new System.Exception("No application to sign out from."), Guid.NewGuid().ToString(), ErrorCategory.InvalidArgument, null));

            AuthenticationHelpers.Logout(authConfig);

            GraphSession.Instance.AuthContext = null;
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
        }
    }
}
