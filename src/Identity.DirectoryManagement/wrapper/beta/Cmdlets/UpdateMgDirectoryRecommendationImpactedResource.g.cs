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
    [GraphRoute("PATCH", "/directory/recommendations/{recommendation-id}/impactedResources/{impactedResource-id}")]
    [Cmdlet(VerbsData.Update, "MgDirectoryRecommendationImpactedResource", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ImpactedResource))]
    public class UpdateMgDirectoryRecommendationImpactedResourceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RecommendationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ImpactedResourceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? AddedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ApiUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? LastModifiedBy { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Owner { get; set; }

        [Parameter(Mandatory = false)]
        public string? PortalUrl { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? PostponeUntilDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public int? Rank { get; set; }

        [Parameter(Mandatory = false)]
        public string? RecommendationId1 { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceType { get; set; }

        [Parameter(Mandatory = false)]
        public string? SubjectId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.KeyValue[]? AdditionalDetails { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.RecommendationStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ImpactedResourceId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ImpactedResource();

    if (this.IsParameterBound(nameof(AddedDateTime)))
        body.AddedDateTime = AddedDateTime;

    if (this.IsParameterBound(nameof(ApiUrl)))
        body.ApiUrl = ApiUrl;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Owner)))
        body.Owner = Owner;

    if (this.IsParameterBound(nameof(PortalUrl)))
        body.PortalUrl = PortalUrl;

    if (this.IsParameterBound(nameof(PostponeUntilDateTime)))
        body.PostponeUntilDateTime = PostponeUntilDateTime;

    if (this.IsParameterBound(nameof(Rank)))
        body.Rank = Rank;

    if (this.IsParameterBound(nameof(RecommendationId1)))
        body.RecommendationId = RecommendationId1;

    if (this.IsParameterBound(nameof(ResourceType)))
        body.ResourceType = ResourceType;

    if (this.IsParameterBound(nameof(SubjectId)))
        body.SubjectId = SubjectId;

    if (this.IsParameterBound(nameof(AdditionalDetails)))
        body.AdditionalDetails = AdditionalDetails!.ToList();

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ImpactedResource? result;
            try
            {
                result = client.Directory.Recommendations[RecommendationId].ImpactedResources[ImpactedResourceId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ImpactedResourceId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Directory.Recommendations[RecommendationId].ImpactedResources[ImpactedResourceId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ImpactedResourceId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
