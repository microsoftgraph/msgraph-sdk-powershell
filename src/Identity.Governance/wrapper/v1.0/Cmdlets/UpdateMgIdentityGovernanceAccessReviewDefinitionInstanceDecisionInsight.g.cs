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
    [GraphRoute("PATCH", "/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition-id}/instances/{accessReviewInstance-id}/decisions/{accessReviewInstanceDecisionItem-id}/insights/{governanceInsight-id}")]
    [Cmdlet(VerbsData.Update, "MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceInsight))]
    public class UpdateMgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsightCommand : GraphClientCmdlet
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
        public global::System.DateTimeOffset? InsightCreatedDateTime { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GovernanceInsightId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceInsight();

    if (this.IsParameterBound(nameof(InsightCreatedDateTime)))
        body.InsightCreatedDateTime = InsightCreatedDateTime;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceInsight? result;
            try
            {
                result = client.IdentityGovernance.AccessReviews.Definitions[AccessReviewScheduleDefinitionId].Instances[AccessReviewInstanceId].Decisions[AccessReviewInstanceDecisionItemId].Insights[GovernanceInsightId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, GovernanceInsightId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.AccessReviews.Definitions[AccessReviewScheduleDefinitionId].Instances[AccessReviewInstanceId].Decisions[AccessReviewInstanceDecisionItemId].Insights[GovernanceInsightId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, GovernanceInsightId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
