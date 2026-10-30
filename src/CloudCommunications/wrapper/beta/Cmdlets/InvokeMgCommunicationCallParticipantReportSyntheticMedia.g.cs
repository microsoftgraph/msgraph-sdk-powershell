#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.CloudCommunications.Client;
using Microsoft.Graph.PowerShell.CloudCommunications.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.CloudCommunications
{
    [GraphRoute("POST", "/communications/calls/{call-id}/participants/{participant-id}/reportSyntheticMedia")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgCommunicationCallParticipantReportSyntheticMedia", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgCommunicationCallParticipantReportSyntheticMediaCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CallId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ParticipantId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public double? OverallConfidence { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsMalicious { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DetectionDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.DetectionSeverity? Severity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.MediaMetadata? ContentMetadata { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.SyntheticMediaDetectionDetail[]? Detections { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ParticipantId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.CloudCommunications.Client.Communications.Calls.Item.Participants.Item.ReportSyntheticMedia.ReportSyntheticMediaPostRequestBody();

    if (this.IsParameterBound(nameof(OverallConfidence)))
        body.OverallConfidence = OverallConfidence;

    if (this.IsParameterBound(nameof(IsMalicious)))
        body.IsMalicious = IsMalicious;

    if (this.IsParameterBound(nameof(DetectionDateTime)))
        body.DetectionDateTime = DetectionDateTime;
    if (this.IsParameterBound(nameof(Severity)))
        body.Severity = Severity;

    if (this.IsParameterBound(nameof(ContentMetadata)))
        body.ContentMetadata = ContentMetadata;

    if (this.IsParameterBound(nameof(Detections)))
        body.Detections = Detections!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Communications.Calls[CallId].Participants[ParticipantId].ReportSyntheticMedia.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ParticipantId);
                return;
            }

        }
    }
}
