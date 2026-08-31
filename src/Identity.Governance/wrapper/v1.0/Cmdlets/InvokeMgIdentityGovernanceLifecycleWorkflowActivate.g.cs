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
    [GraphRoute("POST", "/identityGovernance/lifecycleWorkflows/workflows/{workflow-id}/microsoft.graph.identityGovernance.activate")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgIdentityGovernanceLifecycleWorkflowActivate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgIdentityGovernanceLifecycleWorkflowActivateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WorkflowId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.User[]? Subjects { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WorkflowId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.Governance.Client.IdentityGovernance.LifecycleWorkflows.Workflows.Item.MicrosoftGraphIdentityGovernanceActivate.ActivatePostRequestBody();

    if (this.IsParameterBound(nameof(Subjects)))
        body.Subjects = Subjects!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.IdentityGovernance.LifecycleWorkflows.Workflows[WorkflowId].MicrosoftGraphIdentityGovernanceActivate.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, WorkflowId);
                return;
            }

        }
    }
}
