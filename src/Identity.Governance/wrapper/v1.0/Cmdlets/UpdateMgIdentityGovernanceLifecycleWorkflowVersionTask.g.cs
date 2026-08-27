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
    [GraphRoute("PATCH", "/identityGovernance/lifecycleWorkflows/workflows/{workflow-id}/versions/{workflowVersion-versionNumber}/tasks/{task-id}")]
    [Cmdlet(VerbsData.Update, "MgIdentityGovernanceLifecycleWorkflowVersionTask", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.TaskObject))]
    public class UpdateMgIdentityGovernanceLifecycleWorkflowVersionTaskCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WorkflowId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string WorkflowVersionVersionNumber { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string TaskId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? ContinueOnError { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public int? ExecutionSequence { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string? TaskDefinitionId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.KeyValuePair[]? Arguments { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.LifecycleTaskCategory? Category { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TaskId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.TaskObject();

    if (this.IsParameterBound(nameof(ContinueOnError)))
        body.ContinueOnError = ContinueOnError;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(ExecutionSequence)))
        body.ExecutionSequence = ExecutionSequence;

    if (this.IsParameterBound(nameof(IsEnabled)))
        body.IsEnabled = IsEnabled;

    if (this.IsParameterBound(nameof(TaskDefinitionId)))
        body.TaskDefinitionId = TaskDefinitionId;

    if (this.IsParameterBound(nameof(Arguments)))
        body.Arguments = Arguments!.ToList();

    if (this.IsParameterBound(nameof(Category)))
        body.Category = Category;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.TaskObject? result;
            try
            {
                result = client.IdentityGovernance.LifecycleWorkflows.Workflows[WorkflowId].Versions[WorkflowVersionVersionNumber].Tasks[TaskId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, TaskId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.LifecycleWorkflows.Workflows[WorkflowId].Versions[WorkflowVersionVersionNumber].Tasks[TaskId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, TaskId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
