// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    using Microsoft.Graph.Authentication.Core;
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

            IAuthContext authContext = GraphSession.Instance.AuthContext;

            if (authContext == null)
                ThrowTerminatingError(
                    new ErrorRecord(new Exception("No application to sign out from."), Guid.NewGuid().ToString(), ErrorCategory.InvalidArgument, null));

            Authenticator.LogOut(authContext);

            GraphSession.Instance.AuthContext = null;
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
        }
    }
}
