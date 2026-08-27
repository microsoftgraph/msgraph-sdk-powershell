#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.CloudCommunications.Client;
using Microsoft.Graph.PowerShell.CloudCommunications.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.CloudCommunications
{
    [GraphRoute("PATCH", "/communications/onlineMeetings/{onlineMeeting-id}/transcripts/{callTranscript-id}")]
    [Cmdlet(VerbsData.Update, "MgCommunicationOnlineMeetingTranscript", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallTranscript))]
    public class UpdateMgCommunicationOnlineMeetingTranscriptCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OnlineMeetingId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CallTranscriptId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? CallId { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? Content { get; set; }

        [Parameter(Mandatory = false)]
        public string? ContentCorrelationId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? MeetingId { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? MetadataContent { get; set; }

        [Parameter(Mandatory = false)]
        public string? TranscriptContentUrl { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.IdentitySet? MeetingOrganizer { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CallTranscriptId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallTranscript();

    if (this.IsParameterBound(nameof(CallId)))
        body.CallId = CallId;

    if (this.IsParameterBound(nameof(Content)))
        body.Content = Content;

    if (this.IsParameterBound(nameof(ContentCorrelationId)))
        body.ContentCorrelationId = ContentCorrelationId;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(EndDateTime)))
        body.EndDateTime = EndDateTime;

    if (this.IsParameterBound(nameof(MeetingId)))
        body.MeetingId = MeetingId;

    if (this.IsParameterBound(nameof(MetadataContent)))
        body.MetadataContent = MetadataContent;

    if (this.IsParameterBound(nameof(TranscriptContentUrl)))
        body.TranscriptContentUrl = TranscriptContentUrl;

    if (this.IsParameterBound(nameof(MeetingOrganizer)))
        body.MeetingOrganizer = MeetingOrganizer;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallTranscript? result;
            try
            {
                result = client.Communications.OnlineMeetings[OnlineMeetingId].Transcripts[CallTranscriptId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, CallTranscriptId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Communications.OnlineMeetings[OnlineMeetingId].Transcripts[CallTranscriptId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, CallTranscriptId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
