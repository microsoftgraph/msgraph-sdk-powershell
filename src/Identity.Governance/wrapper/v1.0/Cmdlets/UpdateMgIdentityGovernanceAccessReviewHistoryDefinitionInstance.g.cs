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
    [GraphRoute("PATCH", "/identityGovernance/accessReviews/historyDefinitions/{accessReviewHistoryDefinition-id}/instances/{accessReviewHistoryInstance-id}")]
    [Cmdlet(VerbsData.Update, "MgIdentityGovernanceAccessReviewHistoryDefinitionInstance", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessReviewHistoryInstance))]
    public class UpdateMgIdentityGovernanceAccessReviewHistoryDefinitionInstanceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessReviewHistoryDefinitionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AccessReviewHistoryInstanceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DownloadUri { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? FulfilledDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ReviewHistoryPeriodEndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ReviewHistoryPeriodStartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RunDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessReviewHistoryStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessReviewHistoryInstanceId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessReviewHistoryInstance();

    if (this.IsParameterBound(nameof(DownloadUri)))
        body.DownloadUri = DownloadUri;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(FulfilledDateTime)))
        body.FulfilledDateTime = FulfilledDateTime;

    if (this.IsParameterBound(nameof(ReviewHistoryPeriodEndDateTime)))
        body.ReviewHistoryPeriodEndDateTime = ReviewHistoryPeriodEndDateTime;

    if (this.IsParameterBound(nameof(ReviewHistoryPeriodStartDateTime)))
        body.ReviewHistoryPeriodStartDateTime = ReviewHistoryPeriodStartDateTime;

    if (this.IsParameterBound(nameof(RunDateTime)))
        body.RunDateTime = RunDateTime;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessReviewHistoryInstance? result;
            try
            {
                result = client.IdentityGovernance.AccessReviews.HistoryDefinitions[AccessReviewHistoryDefinitionId].Instances[AccessReviewHistoryInstanceId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AccessReviewHistoryInstanceId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.AccessReviews.HistoryDefinitions[AccessReviewHistoryDefinitionId].Instances[AccessReviewHistoryInstanceId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, AccessReviewHistoryInstanceId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
