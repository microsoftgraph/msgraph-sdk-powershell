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
    [GraphRoute("POST", "/users/{user-id}/onlineMeetings/{onlineMeeting-id}/attendanceReports")]
    [Cmdlet(VerbsCommon.New, "MgUserOnlineMeetingAttendanceReport", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.MeetingAttendanceReport))]
    public class NewMgUserOnlineMeetingAttendanceReportCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string OnlineMeetingId { get; set; } = string.Empty;

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
            if (!ShouldProcess(OnlineMeetingId, "New"))
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
                result = client.Users[UserId].OnlineMeetings[OnlineMeetingId].AttendanceReports.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
