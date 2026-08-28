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
    [GraphRoute("PATCH", "/communications/calls/{call-id}/participants/{participant-id}")]
    [Cmdlet(VerbsData.Update, "MgCommunicationCallParticipant", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.Participant))]
    public class UpdateMgCommunicationCallParticipantCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CallId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ParticipantId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsInLobby { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsMuted { get; set; }

        [Parameter(Mandatory = false)]
        public string? Metadata { get; set; }

        [Parameter(Mandatory = false)]
        public long? RosterSequenceNumber { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.ParticipantInfo? Info { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.MediaStream[]? MediaStreams { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.RecordingInfo? RecordingInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.RemovedState? RemovedState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.OnlineMeetingRestricted? RestrictedExperience { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ParticipantId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.Participant();

    if (this.IsParameterBound(nameof(IsInLobby)))
        body.IsInLobby = IsInLobby;

    if (this.IsParameterBound(nameof(IsMuted)))
        body.IsMuted = IsMuted;

    if (this.IsParameterBound(nameof(Metadata)))
        body.Metadata = Metadata;

    if (this.IsParameterBound(nameof(RosterSequenceNumber)))
        body.RosterSequenceNumber = RosterSequenceNumber;

    if (this.IsParameterBound(nameof(Info)))
        body.Info = Info;

    if (this.IsParameterBound(nameof(MediaStreams)))
        body.MediaStreams = MediaStreams!.ToList();

    if (this.IsParameterBound(nameof(RecordingInfo)))
        body.RecordingInfo = RecordingInfo;

    if (this.IsParameterBound(nameof(RemovedState)))
        body.RemovedState = RemovedState;

    if (this.IsParameterBound(nameof(RestrictedExperience)))
        body.RestrictedExperience = RestrictedExperience;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.Participant? result;
            try
            {
                result = client.Communications.Calls[CallId].Participants[ParticipantId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ParticipantId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Communications.Calls[CallId].Participants[ParticipantId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, ParticipantId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
