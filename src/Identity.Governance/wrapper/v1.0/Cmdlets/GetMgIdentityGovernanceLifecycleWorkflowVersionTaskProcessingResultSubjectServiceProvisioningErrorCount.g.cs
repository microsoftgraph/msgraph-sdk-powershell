#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("GET", "/identityGovernance/lifecycleWorkflows/workflows/{workflow-id}/versions/{workflowVersion-versionNumber}/tasks/{task-id}/taskProcessingResults/{taskProcessingResult-id}/subject/serviceProvisioningErrors/$count")]
    [Cmdlet(VerbsCommon.Get, "MgIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultSubjectServiceProvisioningErrorCount")]
    [OutputType(typeof(int))]
    public class GetMgIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultSubjectServiceProvisioningErrorCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WorkflowId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string WorkflowVersionVersionNumber { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string TaskId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string TaskProcessingResultId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            int? result;
            try
            {
                result = client.IdentityGovernance.LifecycleWorkflows.Workflows[WorkflowId].Versions[WorkflowVersionVersionNumber].Tasks[TaskId].TaskProcessingResults[TaskProcessingResultId].Subject.ServiceProvisioningErrors.Count.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, TaskProcessingResultId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
