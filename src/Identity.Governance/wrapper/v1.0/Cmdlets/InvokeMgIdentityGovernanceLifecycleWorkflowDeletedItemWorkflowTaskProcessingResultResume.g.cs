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
    [GraphRoute("POST", "/identityGovernance/lifecycleWorkflows/deletedItems/workflows/{workflow-id}/tasks/{task-id}/taskProcessingResults/{taskProcessingResult-id}/microsoft.graph.identityGovernance.resume")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTaskProcessingResultResume", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTaskProcessingResultResumeCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WorkflowId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TaskId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string TaskProcessingResultId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Source { get; set; }

        [Parameter(Mandatory = false)]
        public string? Type { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.CustomTaskExtensionCallbackData? Data { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TaskProcessingResultId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.Governance.Client.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.Tasks.Item.TaskProcessingResults.Item.MicrosoftGraphIdentityGovernanceResume.ResumePostRequestBody();

    if (this.IsParameterBound(nameof(Source)))
        body.Source = Source;

    if (this.IsParameterBound(nameof(Type)))
        body.Type = Type;
    if (this.IsParameterBound(nameof(Data)))
        body.Data = Data;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows[WorkflowId].Tasks[TaskId].TaskProcessingResults[TaskProcessingResultId].MicrosoftGraphIdentityGovernanceResume.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, TaskProcessingResultId);
                return;
            }

        }
    }
}
