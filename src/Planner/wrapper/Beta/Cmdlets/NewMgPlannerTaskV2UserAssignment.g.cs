#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Planner.Client;
using Microsoft.Graph.PowerShell.Planner.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Planner
{
    [GraphRoute("POST", "/planner/tasks_v2/{task-id}/userAssignments")]
    [Cmdlet(VerbsCommon.New, "MgPlannerTaskV2UserAssignment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Planner.Client.Models.UserAssignment))]
    public class NewMgPlannerTaskV2UserAssignmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TaskId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? AssignedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.IdentitySet? AssignedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.Identity? User { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TaskId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Planner.Client.Models.UserAssignment();

    if (this.IsParameterBound(nameof(AssignedDateTime)))
        body.AssignedDateTime = AssignedDateTime;

    if (this.IsParameterBound(nameof(AssignedBy)))
        body.AssignedBy = AssignedBy;

    if (this.IsParameterBound(nameof(User)))
        body.User = User;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Planner.Client.Models.UserAssignment? result;
            try
            {
                result = client.Planner.Tasks_v2[TaskId].UserAssignments.PostAsync(body, requestConfiguration =>
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
