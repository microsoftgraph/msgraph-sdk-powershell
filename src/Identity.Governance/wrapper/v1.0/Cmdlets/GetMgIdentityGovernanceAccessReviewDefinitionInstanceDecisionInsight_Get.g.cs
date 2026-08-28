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
    [GraphRoute("GET", "/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition-id}/instances/{accessReviewInstance-id}/decisions/{accessReviewInstanceDecisionItem-id}/insights/{governanceInsight-id}")]
    [Cmdlet(VerbsCommon.Get, "MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceInsight))]
    public class GetMgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessReviewScheduleDefinitionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AccessReviewInstanceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string AccessReviewInstanceDecisionItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string GovernanceInsightId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceInsight? result;
            try
            {
                result = client.IdentityGovernance.AccessReviews.Definitions[AccessReviewScheduleDefinitionId].Instances[AccessReviewInstanceId].Decisions[AccessReviewInstanceDecisionItemId].Insights[GovernanceInsightId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, GovernanceInsightId);
                return;
            }

            WriteObject(result);
        }
    }
}
