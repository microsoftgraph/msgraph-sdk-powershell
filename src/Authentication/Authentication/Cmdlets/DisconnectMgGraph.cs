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
    [Cmdlet(VerbsCommunications.Disconnect, "MgGraph", HelpUri = "https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/disconnect-graph")]
    [Alias("Disconnect-Graph")]
    [OutputType(typeof(IAuthContext))]
    public class DisconnectMgGraph : PSCmdlet
    {
        private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        /// <summary>
        /// When specified, also removes cached accounts for this module from the Windows broker (WAM).
        /// Because the broker store is shared at the OS level, this may sign the user out of other
        /// broker-enabled applications (for example Visual Studio, Azure CLI, or Azure PowerShell)
        /// that are using the same Windows account. Has no effect when the broker is not in use.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "Also removes cached accounts from the Windows broker (WAM). This is a shared, OS-level store, so it may sign you out of other broker-enabled applications (e.g. Visual Studio, Azure CLI, Azure PowerShell) using the same Windows account.")]
        public SwitchParameter SignOutFromBroker { get; set; }

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
            }
            else
            {
                var authContext = await AuthenticationHelpers.LogoutAsync(SignOutFromBroker.IsPresent);
                WriteObject(authContext);
            }
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
        }
    }
}
