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
    [GraphRoute("POST", "/identityGovernance/permissionsManagement/permissionsRequestChanges")]
    [Cmdlet(VerbsCommon.New, "MgIdentityGovernancePermissionManagementPermissionRequestChange", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PermissionsRequestChange))]
    public class NewMgIdentityGovernancePermissionManagementPermissionRequestChangeCommand : GraphClientCmdlet
    {


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
            if (!ShouldProcess(null, "New"))
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
                result = client.IdentityGovernance.PermissionsManagement.PermissionsRequestChanges.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
