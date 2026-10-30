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
    [GraphRoute("POST", "/identityGovernance/privilegedAccess/group/assignmentScheduleRequests/{privilegedAccessGroupAssignmentScheduleRequest-id}/updateRequest")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestUpdateRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedAccessGroupAssignmentScheduleRequest))]
    public class InvokeMgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestUpdateRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrivilegedAccessGroupAssignmentScheduleRequestId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? EvaluationId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Reason { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.EvaluationOutcome? EvaluationOutcome { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.RequestSchedule? ScheduleInfo { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PrivilegedAccessGroupAssignmentScheduleRequestId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.Governance.Client.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.UpdateRequest.UpdateRequestPostRequestBody();

    if (this.IsParameterBound(nameof(EvaluationId)))
        body.EvaluationId = EvaluationId;

    if (this.IsParameterBound(nameof(Reason)))
        body.Reason = Reason;
    if (this.IsParameterBound(nameof(EvaluationOutcome)))
        body.EvaluationOutcome = EvaluationOutcome;

    if (this.IsParameterBound(nameof(ScheduleInfo)))
        body.ScheduleInfo = ScheduleInfo;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedAccessGroupAssignmentScheduleRequest? result;
            try
            {
                result = client.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests[PrivilegedAccessGroupAssignmentScheduleRequestId].UpdateRequest.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PrivilegedAccessGroupAssignmentScheduleRequestId);
                return;
            }

            WriteObject(result);
        }
    }
}
