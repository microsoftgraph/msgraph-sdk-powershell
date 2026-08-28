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
    [GraphRoute("POST", "/identityGovernance/lifecycleWorkflows/workflows/{workflow-id}/microsoft.graph.identityGovernance.previewTaskFailures")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgIdentityGovernanceLifecycleWorkflowPreviewTaskFailures", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Identity.Governance.Client.IdentityGovernance.LifecycleWorkflows.Workflows.Item.MicrosoftGraphIdentityGovernancePreviewTaskFailures.PreviewTaskFailuresPostResponse))]
    public class InvokeMgIdentityGovernanceLifecycleWorkflowPreviewTaskFailuresCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WorkflowId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WorkflowId, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Identity.Governance.Client.IdentityGovernance.LifecycleWorkflows.Workflows.Item.MicrosoftGraphIdentityGovernancePreviewTaskFailures.PreviewTaskFailuresPostResponse? result;
            try
            {
                result = client.IdentityGovernance.LifecycleWorkflows.Workflows[WorkflowId].MicrosoftGraphIdentityGovernancePreviewTaskFailures.PostAsPreviewTaskFailuresPostResponseAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, WorkflowId);
                return;
            }

            WriteObject(result);
        }
    }
}
