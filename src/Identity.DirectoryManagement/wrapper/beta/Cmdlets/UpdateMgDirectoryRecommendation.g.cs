#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("PATCH", "/directory/recommendations/{recommendation-id}")]
    [Cmdlet(VerbsData.Update, "MgDirectoryRecommendation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Recommendation))]
    public class UpdateMgDirectoryRecommendationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RecommendationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Benefits { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CompletedBySystemDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CompletedByUserDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public double? CurrentScore { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? FailedReviewDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ImpactStartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ImpactType { get; set; }

        [Parameter(Mandatory = false)]
        public string? Insights { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastCheckedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? LastModifiedBy { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public double? MaxScore { get; set; }

        [Parameter(Mandatory = false)]
        public int? NeedsMoreActionResourceCount { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? PostponeUntilDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ReleaseType { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RemediatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? RemediationImpact { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StatusModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ActionStep[]? ActionSteps { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.RecommendationCategory? Category { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.RecommendationCategoryGroup? CategoryGroup { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.RecommendationFeatureAreas?[]? FeatureAreas { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.NistClassification[]? NistClassifications { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.RecommendationPriority? Priority { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.RecommendationType? RecommendationType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.RequiredLicenses? RequiredLicenses { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.RecommendationStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(RecommendationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Recommendation();

    if (this.IsParameterBound(nameof(Benefits)))
        body.Benefits = Benefits;

    if (this.IsParameterBound(nameof(CompletedBySystemDateTime)))
        body.CompletedBySystemDateTime = CompletedBySystemDateTime;

    if (this.IsParameterBound(nameof(CompletedByUserDateTime)))
        body.CompletedByUserDateTime = CompletedByUserDateTime;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(CurrentScore)))
        body.CurrentScore = CurrentScore;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(FailedReviewDateTime)))
        body.FailedReviewDateTime = FailedReviewDateTime;

    if (this.IsParameterBound(nameof(ImpactStartDateTime)))
        body.ImpactStartDateTime = ImpactStartDateTime;

    if (this.IsParameterBound(nameof(ImpactType)))
        body.ImpactType = ImpactType;

    if (this.IsParameterBound(nameof(Insights)))
        body.Insights = Insights;

    if (this.IsParameterBound(nameof(LastCheckedDateTime)))
        body.LastCheckedDateTime = LastCheckedDateTime;

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(MaxScore)))
        body.MaxScore = MaxScore;

    if (this.IsParameterBound(nameof(NeedsMoreActionResourceCount)))
        body.NeedsMoreActionResourceCount = NeedsMoreActionResourceCount;

    if (this.IsParameterBound(nameof(PostponeUntilDateTime)))
        body.PostponeUntilDateTime = PostponeUntilDateTime;

    if (this.IsParameterBound(nameof(ReleaseType)))
        body.ReleaseType = ReleaseType;

    if (this.IsParameterBound(nameof(RemediatedDateTime)))
        body.RemediatedDateTime = RemediatedDateTime;

    if (this.IsParameterBound(nameof(RemediationImpact)))
        body.RemediationImpact = RemediationImpact;

    if (this.IsParameterBound(nameof(StatusModifiedDateTime)))
        body.StatusModifiedDateTime = StatusModifiedDateTime;

    if (this.IsParameterBound(nameof(ActionSteps)))
        body.ActionSteps = ActionSteps!.ToList();

    if (this.IsParameterBound(nameof(Category)))
        body.Category = Category;

    if (this.IsParameterBound(nameof(CategoryGroup)))
        body.CategoryGroup = CategoryGroup;

    if (this.IsParameterBound(nameof(FeatureAreas)))
        body.FeatureAreas = FeatureAreas!.ToList();

    if (this.IsParameterBound(nameof(NistClassifications)))
        body.NistClassifications = NistClassifications!.ToList();

    if (this.IsParameterBound(nameof(Priority)))
        body.Priority = Priority;

    if (this.IsParameterBound(nameof(RecommendationType)))
        body.RecommendationType = RecommendationType;

    if (this.IsParameterBound(nameof(RequiredLicenses)))
        body.RequiredLicenses = RequiredLicenses;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Recommendation? result;
            try
            {
                result = client.Directory.Recommendations[RecommendationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, RecommendationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Directory.Recommendations[RecommendationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, RecommendationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
