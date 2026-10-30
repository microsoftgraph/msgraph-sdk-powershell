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
    [GraphRoute("PATCH", "/identityGovernance/permissionsManagement/permissionsRequestChanges/{permissionsRequestChange-id}")]
    [Cmdlet(VerbsData.Update, "MgIdentityGovernancePermissionManagementPermissionRequestChange", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PermissionsRequestChange))]
    public class UpdateMgIdentityGovernancePermissionManagementPermissionRequestChangeCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PermissionsRequestChangeId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ModificationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? PermissionsRequestId { get; set; }

        [Parameter(Mandatory = false)]
        public string? TicketId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PermissionsRequestOccurrenceStatus? ActiveOccurrenceStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.StatusDetail? StatusDetail { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PermissionsRequestChangeId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PermissionsRequestChange();

    if (this.IsParameterBound(nameof(ModificationDateTime)))
        body.ModificationDateTime = ModificationDateTime;

    if (this.IsParameterBound(nameof(PermissionsRequestId)))
        body.PermissionsRequestId = PermissionsRequestId;

    if (this.IsParameterBound(nameof(TicketId)))
        body.TicketId = TicketId;

    if (this.IsParameterBound(nameof(ActiveOccurrenceStatus)))
        body.ActiveOccurrenceStatus = ActiveOccurrenceStatus;

    if (this.IsParameterBound(nameof(StatusDetail)))
        body.StatusDetail = StatusDetail;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PermissionsRequestChange? result;
            try
            {
                result = client.IdentityGovernance.PermissionsManagement.PermissionsRequestChanges[PermissionsRequestChangeId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PermissionsRequestChangeId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.PermissionsManagement.PermissionsRequestChanges[PermissionsRequestChangeId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, PermissionsRequestChangeId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
