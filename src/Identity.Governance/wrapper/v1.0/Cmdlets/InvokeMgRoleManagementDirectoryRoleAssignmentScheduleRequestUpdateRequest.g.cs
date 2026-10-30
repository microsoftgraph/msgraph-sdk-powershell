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
    [GraphRoute("POST", "/roleManagement/directory/roleAssignmentScheduleRequests/{unifiedRoleAssignmentScheduleRequest-id}/updateRequest")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgRoleManagementDirectoryRoleAssignmentScheduleRequestUpdateRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleAssignmentScheduleRequest))]
    public class InvokeMgRoleManagementDirectoryRoleAssignmentScheduleRequestUpdateRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UnifiedRoleAssignmentScheduleRequestId { get; set; } = string.Empty;

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
            if (!ShouldProcess(UnifiedRoleAssignmentScheduleRequestId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.Governance.Client.RoleManagement.DirectoryNamespace.RoleAssignmentScheduleRequests.Item.UpdateRequest.UpdateRequestPostRequestBody();

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

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleAssignmentScheduleRequest? result;
            try
            {
                result = client.RoleManagement.Directory.RoleAssignmentScheduleRequests[UnifiedRoleAssignmentScheduleRequestId].UpdateRequest.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UnifiedRoleAssignmentScheduleRequestId);
                return;
            }

            WriteObject(result);
        }
    }
}
