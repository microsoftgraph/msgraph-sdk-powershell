#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("PATCH", "/security/labels/retentionLabels/{retentionLabel-id}/dispositionReviewStages/{dispositionReviewStage-stageNumber}")]
    [Cmdlet(VerbsData.Update, "MgSecurityLabelRetentionLabelDispositionReviewStage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.DispositionReviewStage))]
    public class UpdateMgSecurityLabelRetentionLabelDispositionReviewStageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RetentionLabelId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DispositionReviewStageStageNumber { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ReviewersEmailAddresses { get; set; }

        [Parameter(Mandatory = false)]
        public string? StageNumber { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DispositionReviewStageStageNumber, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.DispositionReviewStage();

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(ReviewersEmailAddresses)))
        body.ReviewersEmailAddresses = ReviewersEmailAddresses!.ToList();

    if (this.IsParameterBound(nameof(StageNumber)))
        body.StageNumber = StageNumber;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.DispositionReviewStage? result;
            try
            {
                result = client.Security.Labels.RetentionLabels[RetentionLabelId].DispositionReviewStages[DispositionReviewStageStageNumber].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DispositionReviewStageStageNumber);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.Labels.RetentionLabels[RetentionLabelId].DispositionReviewStages[DispositionReviewStageStageNumber].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DispositionReviewStageStageNumber);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
