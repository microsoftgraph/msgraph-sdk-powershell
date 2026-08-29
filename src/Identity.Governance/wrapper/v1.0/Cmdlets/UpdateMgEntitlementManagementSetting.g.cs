#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("PATCH", "/identityGovernance/entitlementManagement/settings")]
    [Cmdlet(VerbsData.Update, "MgEntitlementManagementSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.EntitlementManagementSettings))]
    public class UpdateMgEntitlementManagementSettingCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? DurationUntilExternalUserDeletedAfterBlocked { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageExternalUserLifecycleAction? ExternalUserLifecycleAction { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.EntitlementManagementSettings();

    if (this.IsParameterBound(nameof(DurationUntilExternalUserDeletedAfterBlocked)))
        body.DurationUntilExternalUserDeletedAfterBlocked = DurationUntilExternalUserDeletedAfterBlocked;

    if (this.IsParameterBound(nameof(ExternalUserLifecycleAction)))
        body.ExternalUserLifecycleAction = ExternalUserLifecycleAction;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.EntitlementManagementSettings? result;
            try
            {
                result = client.IdentityGovernance.EntitlementManagement.Settings.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.EntitlementManagement.Settings.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, null);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
