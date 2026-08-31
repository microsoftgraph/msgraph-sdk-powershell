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
    [GraphRoute("GET", "/identityGovernance/lifecycleWorkflows/deletedItems/workflows/{workflow-id}/lastModifiedBy")]
    [Cmdlet(VerbsCommon.Get, "MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowLastModifiedBy")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.User))]
    public class GetMgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowLastModifiedByCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WorkflowId { get; set; } = string.Empty;



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
                result = client.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows[WorkflowId].LastModifiedBy.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, WorkflowId);
                return;
            }

            WriteObject(result);
        }
    }
}
