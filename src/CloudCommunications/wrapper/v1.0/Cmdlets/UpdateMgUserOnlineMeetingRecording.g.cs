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
    [GraphRoute("PATCH", "/users/{user-id}/onlineMeetings/{onlineMeeting-id}/recordings/{callRecording-id}")]
    [Cmdlet(VerbsData.Update, "MgUserOnlineMeetingRecording", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallRecording))]
    public class UpdateMgUserOnlineMeetingRecordingCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string OnlineMeetingId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string CallRecordingId { get; set; } = string.Empty;

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
        public string? RecordingContentUrl { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.IdentitySet? MeetingOrganizer { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CallRecordingId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallRecording();

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

    if (this.IsParameterBound(nameof(RecordingContentUrl)))
        body.RecordingContentUrl = RecordingContentUrl;

    if (this.IsParameterBound(nameof(MeetingOrganizer)))
        body.MeetingOrganizer = MeetingOrganizer;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallRecording? result;
            try
            {
                result = client.Users[UserId].OnlineMeetings[OnlineMeetingId].Recordings[CallRecordingId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, CallRecordingId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].OnlineMeetings[OnlineMeetingId].Recordings[CallRecordingId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, CallRecordingId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
