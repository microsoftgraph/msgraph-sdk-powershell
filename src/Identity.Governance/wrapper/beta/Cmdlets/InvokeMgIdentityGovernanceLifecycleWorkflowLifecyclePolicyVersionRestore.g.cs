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
    [GraphRoute("POST", "/identityGovernance/lifecycleWorkflows/lifecyclePolicies/{lifecyclePolicy-id}/versions/{lifecyclePolicy-id1}/microsoft.graph.identityGovernance.restore")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgIdentityGovernanceLifecycleWorkflowLifecyclePolicyVersionRestore", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.LifecyclePolicy))]
    public class InvokeMgIdentityGovernanceLifecycleWorkflowLifecyclePolicyVersionRestoreCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string LifecyclePolicyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string LifecyclePolicyId1 { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(LifecyclePolicyId1, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.LifecyclePolicy? result;
            try
            {
                result = client.IdentityGovernance.LifecycleWorkflows.LifecyclePolicies[LifecyclePolicyId].Versions[LifecyclePolicyId1].MicrosoftGraphIdentityGovernanceRestore.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, LifecyclePolicyId1);
                return;
            }

            WriteObject(result);
        }
    }
}
