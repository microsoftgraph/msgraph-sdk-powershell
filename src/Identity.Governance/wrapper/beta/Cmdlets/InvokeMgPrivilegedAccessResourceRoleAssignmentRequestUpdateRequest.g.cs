#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("POST", "/privilegedAccess/{privilegedAccess-id}/resources/{governanceResource-id}/roleAssignmentRequests/{governanceRoleAssignmentRequest-id}/updateRequest")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgPrivilegedAccessResourceRoleAssignmentRequestUpdateRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceRoleAssignmentRequest))]
    public class InvokeMgPrivilegedAccessResourceRoleAssignmentRequestUpdateRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrivilegedAccessId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string GovernanceResourceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string GovernanceRoleAssignmentRequestId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Decision { get; set; }

        [Parameter(Mandatory = false)]
        public string? AssignmentState { get; set; }

        [Parameter(Mandatory = false)]
        public string? Reason { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceSchedule? Schedule { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GovernanceRoleAssignmentRequestId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.Governance.Client.PrivilegedAccess.Item.Resources.Item.RoleAssignmentRequests.Item.UpdateRequest.UpdateRequestPostRequestBody();

    if (this.IsParameterBound(nameof(Decision)))
        body.Decision = Decision;

    if (this.IsParameterBound(nameof(AssignmentState)))
        body.AssignmentState = AssignmentState;

    if (this.IsParameterBound(nameof(Reason)))
        body.Reason = Reason;
    if (this.IsParameterBound(nameof(Schedule)))
        body.Schedule = Schedule;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceRoleAssignmentRequest? result;
            try
            {
                result = client.PrivilegedAccess[PrivilegedAccessId].Resources[GovernanceResourceId].RoleAssignmentRequests[GovernanceRoleAssignmentRequestId].UpdateRequest.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, GovernanceRoleAssignmentRequestId);
                return;
            }

            WriteObject(result);
        }
    }
}
