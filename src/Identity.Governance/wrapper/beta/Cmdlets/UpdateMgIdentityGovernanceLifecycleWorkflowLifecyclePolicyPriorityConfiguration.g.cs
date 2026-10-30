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
    [GraphRoute("PATCH", "/identityGovernance/lifecycleWorkflows/lifecyclePolicyPriorityConfigurations/{lifecyclePolicyPriorityConfiguration-id}")]
    [Cmdlet(VerbsData.Update, "MgIdentityGovernanceLifecycleWorkflowLifecyclePolicyPriorityConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.LifecyclePolicyPriorityConfiguration))]
    public class UpdateMgIdentityGovernanceLifecycleWorkflowLifecyclePolicyPriorityConfigurationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string LifecyclePolicyPriorityConfigurationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? OrderedPolicyIds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.SubjectType? SubjectType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(LifecyclePolicyPriorityConfigurationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.LifecyclePolicyPriorityConfiguration();

    if (this.IsParameterBound(nameof(OrderedPolicyIds)))
        body.OrderedPolicyIds = OrderedPolicyIds!.ToList();

    if (this.IsParameterBound(nameof(SubjectType)))
        body.SubjectType = SubjectType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.LifecyclePolicyPriorityConfiguration? result;
            try
            {
                result = client.IdentityGovernance.LifecycleWorkflows.LifecyclePolicyPriorityConfigurations[LifecyclePolicyPriorityConfigurationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, LifecyclePolicyPriorityConfigurationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.LifecycleWorkflows.LifecyclePolicyPriorityConfigurations[LifecyclePolicyPriorityConfigurationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, LifecyclePolicyPriorityConfigurationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
