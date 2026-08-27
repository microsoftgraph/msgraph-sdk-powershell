#nullable enable

using System;
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
    [GraphRoute("GET", "/identityGovernance/lifecycleWorkflows/workflows/{workflow-id}/taskReports/{taskReport-id}/taskProcessingResults/{taskProcessingResult-id}/subject")]
    [Cmdlet(VerbsCommon.Get, "MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubject")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.User))]
    public class GetMgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubjectCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WorkflowId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TaskReportId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string TaskProcessingResultId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.User? result;
            try
            {
                result = client.IdentityGovernance.LifecycleWorkflows.Workflows[WorkflowId].TaskReports[TaskReportId].TaskProcessingResults[TaskProcessingResultId].Subject.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, TaskProcessingResultId);
                return;
            }

            WriteObject(result);
        }
    }
}
