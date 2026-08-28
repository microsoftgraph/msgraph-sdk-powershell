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
    [GraphRoute("PATCH", "/users/{user-id}/onlineMeetings/{onlineMeeting-id}/attendanceReports/{meetingAttendanceReport-id}")]
    [Cmdlet(VerbsData.Update, "MgUserOnlineMeetingAttendanceReport", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.MeetingAttendanceReport))]
    public class UpdateMgUserOnlineMeetingAttendanceReportCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string OnlineMeetingId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string MeetingAttendanceReportId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? MeetingEndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? MeetingStartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public int? TotalParticipantCount { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.VirtualEventExternalInformation[]? ExternalEventInformation { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MeetingAttendanceReportId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.MeetingAttendanceReport();

    if (this.IsParameterBound(nameof(MeetingEndDateTime)))
        body.MeetingEndDateTime = MeetingEndDateTime;

    if (this.IsParameterBound(nameof(MeetingStartDateTime)))
        body.MeetingStartDateTime = MeetingStartDateTime;

    if (this.IsParameterBound(nameof(TotalParticipantCount)))
        body.TotalParticipantCount = TotalParticipantCount;

    if (this.IsParameterBound(nameof(ExternalEventInformation)))
        body.ExternalEventInformation = ExternalEventInformation!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.MeetingAttendanceReport? result;
            try
            {
                result = client.Users[UserId].OnlineMeetings[OnlineMeetingId].AttendanceReports[MeetingAttendanceReportId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, MeetingAttendanceReportId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].OnlineMeetings[OnlineMeetingId].AttendanceReports[MeetingAttendanceReportId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, MeetingAttendanceReportId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
