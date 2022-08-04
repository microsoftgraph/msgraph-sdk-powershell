// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
using Microsoft.Graph.PowerShell.Authentication.Core.Utilities;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using System;
using System.Management.Automation;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    [Cmdlet(VerbsCommunications.Disconnect, "MgGraph")]
    [Alias("Disconnect-Graph")]
    [OutputType(typeof(IAuthContext))]
    public class DisconnectMgGraph : PSCmdlet
    {
        private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

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
            try
            {
                using (var asyncCommandRuntime = new CustomAsyncCommandRuntime(this, _cancellationTokenSource.Token))
                    asyncCommandRuntime.Wait(ProcessRecordAsync());
            }
            catch (Exception exception)
            {
                WriteError(new ErrorRecord(exception, string.Empty, ErrorCategory.NotSpecified, null));
            }
        }

        private async Task ProcessRecordAsync()
        {
            if (GraphSession.Instance.AuthContext is null)
            {
                WriteError(new ErrorRecord(new ArgumentException("No application to sign out from."), string.Empty, ErrorCategory.CloseError, null));
            } else {
                var authContext = await AuthenticationHelpers.LogoutAsync();
                WriteObject(authContext);
            }
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
        }
    }
}
