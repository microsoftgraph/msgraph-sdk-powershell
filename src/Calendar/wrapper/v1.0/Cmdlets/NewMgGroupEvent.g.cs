#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Calendar.Client;
using Microsoft.Graph.PowerShell.Calendar.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Calendar
{
    [GraphRoute("POST", "/groups/{group-id}/events")]
    [Cmdlet(VerbsCommon.New, "MgGroupEvent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Calendar.Client.Models.Event))]
    public class NewMgGroupEventCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? Categories { get; set; }

        [Parameter(Mandatory = false)]
        public string? ChangeKey { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowNewTimeProposals { get; set; }

        [Parameter(Mandatory = false)]
        public string? BodyPreview { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? CancelledOccurrences { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HasAttachments { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HideAttendees { get; set; }

        [Parameter(Mandatory = false)]
        public string? ICalUId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsAllDay { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsCancelled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDraft { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsOnlineMeeting { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsOrganizer { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsReminderOn { get; set; }

        [Parameter(Mandatory = false)]
        public string? OnlineMeetingUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? OriginalEndTimeZone { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? OriginalStart { get; set; }

        [Parameter(Mandatory = false)]
        public string? OriginalStartTimeZone { get; set; }

        [Parameter(Mandatory = false)]
        public int? ReminderMinutesBeforeStart { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ResponseRequested { get; set; }

        [Parameter(Mandatory = false)]
        public string? SeriesMasterId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Subject { get; set; }

        [Parameter(Mandatory = false)]
        public string? TransactionId { get; set; }

        [Parameter(Mandatory = false)]
        public string? WebLink { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.Attendee[]? Attendees { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.ItemBody? Body { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.DateTimeTimeZone? End { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.Importance? Importance { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.Location? Location { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.Location[]? Locations { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.OnlineMeetingInfo? OnlineMeeting { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.OnlineMeetingProviderType? OnlineMeetingProvider { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.Recipient? Organizer { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.PatternedRecurrence? Recurrence { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.ResponseStatus? ResponseStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.Sensitivity? Sensitivity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.FreeBusyStatus? ShowAs { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.DateTimeTimeZone? Start { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.EventType? Type { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GroupId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Calendar.Client.Models.Event();

    if (this.IsParameterBound(nameof(Categories)))
        body.Categories = Categories!.ToList();

    if (this.IsParameterBound(nameof(ChangeKey)))
        body.ChangeKey = ChangeKey;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(AllowNewTimeProposals)))
        body.AllowNewTimeProposals = AllowNewTimeProposals;

    if (this.IsParameterBound(nameof(BodyPreview)))
        body.BodyPreview = BodyPreview;

    if (this.IsParameterBound(nameof(CancelledOccurrences)))
        body.CancelledOccurrences = CancelledOccurrences!.ToList();

    if (this.IsParameterBound(nameof(HasAttachments)))
        body.HasAttachments = HasAttachments;

    if (this.IsParameterBound(nameof(HideAttendees)))
        body.HideAttendees = HideAttendees;

    if (this.IsParameterBound(nameof(ICalUId)))
        body.ICalUId = ICalUId;

    if (this.IsParameterBound(nameof(IsAllDay)))
        body.IsAllDay = IsAllDay;

    if (this.IsParameterBound(nameof(IsCancelled)))
        body.IsCancelled = IsCancelled;

    if (this.IsParameterBound(nameof(IsDraft)))
        body.IsDraft = IsDraft;

    if (this.IsParameterBound(nameof(IsOnlineMeeting)))
        body.IsOnlineMeeting = IsOnlineMeeting;

    if (this.IsParameterBound(nameof(IsOrganizer)))
        body.IsOrganizer = IsOrganizer;

    if (this.IsParameterBound(nameof(IsReminderOn)))
        body.IsReminderOn = IsReminderOn;

    if (this.IsParameterBound(nameof(OnlineMeetingUrl)))
        body.OnlineMeetingUrl = OnlineMeetingUrl;

    if (this.IsParameterBound(nameof(OriginalEndTimeZone)))
        body.OriginalEndTimeZone = OriginalEndTimeZone;

    if (this.IsParameterBound(nameof(OriginalStart)))
        body.OriginalStart = OriginalStart;

    if (this.IsParameterBound(nameof(OriginalStartTimeZone)))
        body.OriginalStartTimeZone = OriginalStartTimeZone;

    if (this.IsParameterBound(nameof(ReminderMinutesBeforeStart)))
        body.ReminderMinutesBeforeStart = ReminderMinutesBeforeStart;

    if (this.IsParameterBound(nameof(ResponseRequested)))
        body.ResponseRequested = ResponseRequested;

    if (this.IsParameterBound(nameof(SeriesMasterId)))
        body.SeriesMasterId = SeriesMasterId;

    if (this.IsParameterBound(nameof(Subject)))
        body.Subject = Subject;

    if (this.IsParameterBound(nameof(TransactionId)))
        body.TransactionId = TransactionId;

    if (this.IsParameterBound(nameof(WebLink)))
        body.WebLink = WebLink;

    if (this.IsParameterBound(nameof(Attendees)))
        body.Attendees = Attendees!.ToList();

    if (this.IsParameterBound(nameof(Body)))
        body.Body = Body;

    if (this.IsParameterBound(nameof(End)))
        body.End = End;

    if (this.IsParameterBound(nameof(Importance)))
        body.Importance = Importance;

    if (this.IsParameterBound(nameof(Location)))
        body.Location = Location;

    if (this.IsParameterBound(nameof(Locations)))
        body.Locations = Locations!.ToList();

    if (this.IsParameterBound(nameof(OnlineMeeting)))
        body.OnlineMeeting = OnlineMeeting;

    if (this.IsParameterBound(nameof(OnlineMeetingProvider)))
        body.OnlineMeetingProvider = OnlineMeetingProvider;

    if (this.IsParameterBound(nameof(Organizer)))
        body.Organizer = Organizer;

    if (this.IsParameterBound(nameof(Recurrence)))
        body.Recurrence = Recurrence;

    if (this.IsParameterBound(nameof(ResponseStatus)))
        body.ResponseStatus = ResponseStatus;

    if (this.IsParameterBound(nameof(Sensitivity)))
        body.Sensitivity = Sensitivity;

    if (this.IsParameterBound(nameof(ShowAs)))
        body.ShowAs = ShowAs;

    if (this.IsParameterBound(nameof(Start)))
        body.Start = Start;

    if (this.IsParameterBound(nameof(Type)))
        body.Type = Type;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Calendar.Client.Models.Event? result;
            try
            {
                result = client.Groups[GroupId].Events.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
