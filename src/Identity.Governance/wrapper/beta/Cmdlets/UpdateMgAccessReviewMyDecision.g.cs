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
    [GraphRoute("PATCH", "/accessReviews/{accessReview-id}/myDecisions/{accessReviewDecision-id}")]
    [Cmdlet(VerbsData.Update, "MgAccessReviewMyDecision", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessReviewDecision))]
    public class UpdateMgAccessReviewMyDecisionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessReviewId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AccessReviewDecisionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AccessRecommendation { get; set; }

        [Parameter(Mandatory = false)]
        public string? AccessReviewId1 { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? AppliedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ApplyResult { get; set; }

        [Parameter(Mandatory = false)]
        public string? Justification { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ReviewedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ReviewResult { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UserIdentity? AppliedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UserIdentity? ReviewedBy { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessReviewDecisionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessReviewDecision();

    if (this.IsParameterBound(nameof(AccessRecommendation)))
        body.AccessRecommendation = AccessRecommendation;

    if (this.IsParameterBound(nameof(AccessReviewId1)))
        body.AccessReviewId = AccessReviewId1;

    if (this.IsParameterBound(nameof(AppliedDateTime)))
        body.AppliedDateTime = AppliedDateTime;

    if (this.IsParameterBound(nameof(ApplyResult)))
        body.ApplyResult = ApplyResult;

    if (this.IsParameterBound(nameof(Justification)))
        body.Justification = Justification;

    if (this.IsParameterBound(nameof(ReviewedDateTime)))
        body.ReviewedDateTime = ReviewedDateTime;

    if (this.IsParameterBound(nameof(ReviewResult)))
        body.ReviewResult = ReviewResult;

    if (this.IsParameterBound(nameof(AppliedBy)))
        body.AppliedBy = AppliedBy;

    if (this.IsParameterBound(nameof(ReviewedBy)))
        body.ReviewedBy = ReviewedBy;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessReviewDecision? result;
            try
            {
                result = client.AccessReviews[AccessReviewId].MyDecisions[AccessReviewDecisionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AccessReviewDecisionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.AccessReviews[AccessReviewId].MyDecisions[AccessReviewDecisionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, AccessReviewDecisionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
