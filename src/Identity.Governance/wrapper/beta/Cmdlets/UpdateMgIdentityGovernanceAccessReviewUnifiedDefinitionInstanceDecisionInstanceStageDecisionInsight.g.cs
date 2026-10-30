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
    [GraphRoute("PATCH", "/identityGovernance/accessReviews/unified/definitions/{accessReviewScheduleDefinition-id}/instances/{accessReviewInstance-id}/decisions/{accessReviewInstanceDecisionItem-id}/instance/stages/{accessReviewStage-id}/decisions/{accessReviewInstanceDecisionItem-id1}/insights/{governanceInsight-id}")]
    [Cmdlet(VerbsData.Update, "MgIdentityGovernanceAccessReviewUnifiedDefinitionInstanceDecisionInstanceStageDecisionInsight", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceInsight))]
    public class UpdateMgIdentityGovernanceAccessReviewUnifiedDefinitionInstanceDecisionInstanceStageDecisionInsightCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessReviewScheduleDefinitionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AccessReviewInstanceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string AccessReviewInstanceDecisionItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string AccessReviewStageId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 4)]
        public string AccessReviewInstanceDecisionItemId1 { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 5)]
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
                result = client.IdentityGovernance.AccessReviews.Unified.Definitions[AccessReviewScheduleDefinitionId].Instances[AccessReviewInstanceId].Decisions[AccessReviewInstanceDecisionItemId].Instance.Stages[AccessReviewStageId].Decisions[AccessReviewInstanceDecisionItemId1].Insights[GovernanceInsightId].PatchAsync(body, requestConfiguration =>
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
                    result = client.IdentityGovernance.AccessReviews.Unified.Definitions[AccessReviewScheduleDefinitionId].Instances[AccessReviewInstanceId].Decisions[AccessReviewInstanceDecisionItemId].Instance.Stages[AccessReviewStageId].Decisions[AccessReviewInstanceDecisionItemId1].Insights[GovernanceInsightId].GetAsync().GetAwaiter().GetResult();
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
