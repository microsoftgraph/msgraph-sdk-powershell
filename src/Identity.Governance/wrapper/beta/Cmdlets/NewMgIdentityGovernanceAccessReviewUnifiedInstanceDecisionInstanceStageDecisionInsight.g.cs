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
    [GraphRoute("POST", "/identityGovernance/accessReviews/unified/instances/{accessReviewInstance-id}/decisions/{accessReviewInstanceDecisionItem-id}/instance/stages/{accessReviewStage-id}/decisions/{accessReviewInstanceDecisionItem-id1}/insights")]
    [Cmdlet(VerbsCommon.New, "MgIdentityGovernanceAccessReviewUnifiedInstanceDecisionInstanceStageDecisionInsight", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceInsight))]
    public class NewMgIdentityGovernanceAccessReviewUnifiedInstanceDecisionInstanceStageDecisionInsightCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessReviewInstanceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AccessReviewInstanceDecisionItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string AccessReviewStageId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string AccessReviewInstanceDecisionItemId1 { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? InsightCreatedDateTime { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessReviewInstanceDecisionItemId1, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceInsight();

    if (this.IsParameterBound(nameof(InsightCreatedDateTime)))
        body.InsightCreatedDateTime = InsightCreatedDateTime;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceInsight? result;
            try
            {
                result = client.IdentityGovernance.AccessReviews.Unified.Instances[AccessReviewInstanceId].Decisions[AccessReviewInstanceDecisionItemId].Instance.Stages[AccessReviewStageId].Decisions[AccessReviewInstanceDecisionItemId1].Insights.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
