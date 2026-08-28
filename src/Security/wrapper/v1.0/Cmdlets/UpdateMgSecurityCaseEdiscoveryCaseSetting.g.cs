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
    [GraphRoute("PATCH", "/security/cases/ediscoveryCases/{ediscoveryCase-id}/settings")]
    [Cmdlet(VerbsData.Update, "MgSecurityCaseEdiscoveryCaseSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.EdiscoveryCaseSettings))]
    public class UpdateMgSecurityCaseEdiscoveryCaseSettingCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EdiscoveryCaseId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.CaseType? CaseType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.OcrSettings? Ocr { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.RedundancyDetectionSettings? RedundancyDetection { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.ReviewSetSettings? ReviewSetSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.TopicModelingSettings? TopicModeling { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EdiscoveryCaseId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.EdiscoveryCaseSettings();


    if (this.IsParameterBound(nameof(CaseType)))
        body.CaseType = CaseType;

    if (this.IsParameterBound(nameof(Ocr)))
        body.Ocr = Ocr;

    if (this.IsParameterBound(nameof(RedundancyDetection)))
        body.RedundancyDetection = RedundancyDetection;

    if (this.IsParameterBound(nameof(ReviewSetSettings)))
        body.ReviewSetSettings = ReviewSetSettings;

    if (this.IsParameterBound(nameof(TopicModeling)))
        body.TopicModeling = TopicModeling;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.EdiscoveryCaseSettings? result;
            try
            {
                result = client.Security.Cases.EdiscoveryCases[EdiscoveryCaseId].Settings.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, EdiscoveryCaseId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.Cases.EdiscoveryCases[EdiscoveryCaseId].Settings.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, EdiscoveryCaseId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
