// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    using Microsoft.Graph.Authentication.Core;
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

            if (GraphSession.Instance.AuthContext == null)
            {
                WriteError(new ErrorRecord(new ArgumentException("No application to sign out from."), string.Empty, ErrorCategory.CloseError, null));
            } else
            {
                Authenticator.LogOut(GraphSession.Instance.AuthContext);
                GraphSession.Instance.AuthContext = null;
                GraphSession.Instance.GraphHttpClient = null;
            }
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
        }
    }
}
