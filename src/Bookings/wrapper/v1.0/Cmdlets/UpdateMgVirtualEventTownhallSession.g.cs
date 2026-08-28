#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Bookings.Client;
using Microsoft.Graph.PowerShell.Bookings.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Bookings
{
    [GraphRoute("PATCH", "/solutions/virtualEvents/townhalls/{virtualEventTownhall-id}/sessions/{virtualEventSession-id}")]
    [Cmdlet(VerbsData.Update, "MgVirtualEventTownhallSession", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventSession))]
    public class UpdateMgVirtualEventTownhallSessionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string VirtualEventTownhallId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string VirtualEventSessionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? AllowAttendeeToEnableCamera { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowAttendeeToEnableMic { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowBreakoutRooms { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowCopyingAndSharingMeetingContent { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowParticipantsToChangeName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowPowerPointSharing { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowRecording { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowTeamworkReactions { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowTranscription { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowWhiteboard { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpiryDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsEndToEndEncryptionEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsEntryExitAnnounced { get; set; }

        [Parameter(Mandatory = false)]
        public string? JoinWebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? MeetingOptionsWebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? MeetingSpokenLanguageTag { get; set; }

        [Parameter(Mandatory = false)]
        public bool? RecordAutomatically { get; set; }

        [Parameter(Mandatory = false)]
        public string? Subject { get; set; }

        [Parameter(Mandatory = false)]
        public string? VideoTeleconferenceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? VideoOnDemandWebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.AllowedLobbyAdmitterRoles? AllowedLobbyAdmitters { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.OnlineMeetingPresenters? AllowedPresenters { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.MeetingLiveShareOptions? AllowLiveShare { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.MeetingChatMode? AllowMeetingChat { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.AudioConferencing? AudioConferencing { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.ChatInfo? ChatInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.ChatRestrictions? ChatRestrictions { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.ItemBody? JoinInformation { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.JoinMeetingIdSettings? JoinMeetingIdSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.LobbyBypassSettings? LobbyBypassSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.OnlineMeetingSensitivityLabelAssignment? SensitivityLabelAssignment { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.MeetingChatHistoryDefaultMode? ShareMeetingChatHistoryDefault { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.WatermarkProtectionValues? WatermarkProtection { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.DateTimeTimeZone? EndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.DateTimeTimeZone? StartDateTime { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(VirtualEventSessionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventSession();

    if (this.IsParameterBound(nameof(AllowAttendeeToEnableCamera)))
        body.AllowAttendeeToEnableCamera = AllowAttendeeToEnableCamera;

    if (this.IsParameterBound(nameof(AllowAttendeeToEnableMic)))
        body.AllowAttendeeToEnableMic = AllowAttendeeToEnableMic;

    if (this.IsParameterBound(nameof(AllowBreakoutRooms)))
        body.AllowBreakoutRooms = AllowBreakoutRooms;

    if (this.IsParameterBound(nameof(AllowCopyingAndSharingMeetingContent)))
        body.AllowCopyingAndSharingMeetingContent = AllowCopyingAndSharingMeetingContent;

    if (this.IsParameterBound(nameof(AllowParticipantsToChangeName)))
        body.AllowParticipantsToChangeName = AllowParticipantsToChangeName;

    if (this.IsParameterBound(nameof(AllowPowerPointSharing)))
        body.AllowPowerPointSharing = AllowPowerPointSharing;

    if (this.IsParameterBound(nameof(AllowRecording)))
        body.AllowRecording = AllowRecording;

    if (this.IsParameterBound(nameof(AllowTeamworkReactions)))
        body.AllowTeamworkReactions = AllowTeamworkReactions;

    if (this.IsParameterBound(nameof(AllowTranscription)))
        body.AllowTranscription = AllowTranscription;

    if (this.IsParameterBound(nameof(AllowWhiteboard)))
        body.AllowWhiteboard = AllowWhiteboard;

    if (this.IsParameterBound(nameof(ExpiryDateTime)))
        body.ExpiryDateTime = ExpiryDateTime;

    if (this.IsParameterBound(nameof(IsEndToEndEncryptionEnabled)))
        body.IsEndToEndEncryptionEnabled = IsEndToEndEncryptionEnabled;

    if (this.IsParameterBound(nameof(IsEntryExitAnnounced)))
        body.IsEntryExitAnnounced = IsEntryExitAnnounced;

    if (this.IsParameterBound(nameof(JoinWebUrl)))
        body.JoinWebUrl = JoinWebUrl;

    if (this.IsParameterBound(nameof(MeetingOptionsWebUrl)))
        body.MeetingOptionsWebUrl = MeetingOptionsWebUrl;

    if (this.IsParameterBound(nameof(MeetingSpokenLanguageTag)))
        body.MeetingSpokenLanguageTag = MeetingSpokenLanguageTag;

    if (this.IsParameterBound(nameof(RecordAutomatically)))
        body.RecordAutomatically = RecordAutomatically;

    if (this.IsParameterBound(nameof(Subject)))
        body.Subject = Subject;

    if (this.IsParameterBound(nameof(VideoTeleconferenceId)))
        body.VideoTeleconferenceId = VideoTeleconferenceId;

    if (this.IsParameterBound(nameof(VideoOnDemandWebUrl)))
        body.VideoOnDemandWebUrl = VideoOnDemandWebUrl;

    if (this.IsParameterBound(nameof(AllowedLobbyAdmitters)))
        body.AllowedLobbyAdmitters = AllowedLobbyAdmitters;

    if (this.IsParameterBound(nameof(AllowedPresenters)))
        body.AllowedPresenters = AllowedPresenters;

    if (this.IsParameterBound(nameof(AllowLiveShare)))
        body.AllowLiveShare = AllowLiveShare;

    if (this.IsParameterBound(nameof(AllowMeetingChat)))
        body.AllowMeetingChat = AllowMeetingChat;

    if (this.IsParameterBound(nameof(AudioConferencing)))
        body.AudioConferencing = AudioConferencing;

    if (this.IsParameterBound(nameof(ChatInfo)))
        body.ChatInfo = ChatInfo;

    if (this.IsParameterBound(nameof(ChatRestrictions)))
        body.ChatRestrictions = ChatRestrictions;

    if (this.IsParameterBound(nameof(JoinInformation)))
        body.JoinInformation = JoinInformation;

    if (this.IsParameterBound(nameof(JoinMeetingIdSettings)))
        body.JoinMeetingIdSettings = JoinMeetingIdSettings;

    if (this.IsParameterBound(nameof(LobbyBypassSettings)))
        body.LobbyBypassSettings = LobbyBypassSettings;

    if (this.IsParameterBound(nameof(SensitivityLabelAssignment)))
        body.SensitivityLabelAssignment = SensitivityLabelAssignment;

    if (this.IsParameterBound(nameof(ShareMeetingChatHistoryDefault)))
        body.ShareMeetingChatHistoryDefault = ShareMeetingChatHistoryDefault;

    if (this.IsParameterBound(nameof(WatermarkProtection)))
        body.WatermarkProtection = WatermarkProtection;

    if (this.IsParameterBound(nameof(EndDateTime)))
        body.EndDateTime = EndDateTime;

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventSession? result;
            try
            {
                result = client.Solutions.VirtualEvents.Townhalls[VirtualEventTownhallId].Sessions[VirtualEventSessionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, VirtualEventSessionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Solutions.VirtualEvents.Townhalls[VirtualEventTownhallId].Sessions[VirtualEventSessionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, VirtualEventSessionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
