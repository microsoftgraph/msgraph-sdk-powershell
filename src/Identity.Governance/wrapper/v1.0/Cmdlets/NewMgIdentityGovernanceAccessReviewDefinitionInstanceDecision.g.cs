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
    [GraphRoute("POST", "/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition-id}/instances/{accessReviewInstance-id}/decisions")]
    [Cmdlet(VerbsCommon.New, "MgIdentityGovernanceAccessReviewDefinitionInstanceDecision", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessReviewInstanceDecisionItem))]
    public class NewMgIdentityGovernanceAccessReviewDefinitionInstanceDecisionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessReviewScheduleDefinitionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AccessReviewInstanceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AccessReviewId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? AppliedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ApplyResult { get; set; }

        [Parameter(Mandatory = false)]
        public string? Decision { get; set; }

        [Parameter(Mandatory = false)]
        public string? Justification { get; set; }

        [Parameter(Mandatory = false)]
        public string? PrincipalLink { get; set; }

        [Parameter(Mandatory = false)]
        public string? Recommendation { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceLink { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ReviewedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UserIdentity? AppliedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.Identity? Principal { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessReviewInstanceDecisionItemResource? Resource { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UserIdentity? ReviewedBy { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessReviewInstanceId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessReviewInstanceDecisionItem();

    if (this.IsParameterBound(nameof(AccessReviewId)))
        body.AccessReviewId = AccessReviewId;

    if (this.IsParameterBound(nameof(AppliedDateTime)))
        body.AppliedDateTime = AppliedDateTime;

    if (this.IsParameterBound(nameof(ApplyResult)))
        body.ApplyResult = ApplyResult;

    if (this.IsParameterBound(nameof(Decision)))
        body.Decision = Decision;

    if (this.IsParameterBound(nameof(Justification)))
        body.Justification = Justification;

    if (this.IsParameterBound(nameof(PrincipalLink)))
        body.PrincipalLink = PrincipalLink;

    if (this.IsParameterBound(nameof(Recommendation)))
        body.Recommendation = Recommendation;

    if (this.IsParameterBound(nameof(ResourceLink)))
        body.ResourceLink = ResourceLink;

    if (this.IsParameterBound(nameof(ReviewedDateTime)))
        body.ReviewedDateTime = ReviewedDateTime;

    if (this.IsParameterBound(nameof(AppliedBy)))
        body.AppliedBy = AppliedBy;

    if (this.IsParameterBound(nameof(Principal)))
        body.Principal = Principal;

    if (this.IsParameterBound(nameof(Resource)))
        body.Resource = Resource;

    if (this.IsParameterBound(nameof(ReviewedBy)))
        body.ReviewedBy = ReviewedBy;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessReviewInstanceDecisionItem? result;
            try
            {
                result = client.IdentityGovernance.AccessReviews.Definitions[AccessReviewScheduleDefinitionId].Instances[AccessReviewInstanceId].Decisions.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
