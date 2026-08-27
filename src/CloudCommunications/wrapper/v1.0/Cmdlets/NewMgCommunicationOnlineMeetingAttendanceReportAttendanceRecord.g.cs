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
    [GraphRoute("POST", "/communications/onlineMeetings/{onlineMeeting-id}/attendanceReports/{meetingAttendanceReport-id}/attendanceRecords")]
    [Cmdlet(VerbsCommon.New, "MgCommunicationOnlineMeetingAttendanceReportAttendanceRecord", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.AttendanceRecord))]
    public class NewMgCommunicationOnlineMeetingAttendanceReportAttendanceRecordCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OnlineMeetingId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MeetingAttendanceReportId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? EmailAddress { get; set; }

        [Parameter(Mandatory = false)]
        public string? RegistrationId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Role { get; set; }

        [Parameter(Mandatory = false)]
        public int? TotalAttendanceInSeconds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.AttendanceInterval[]? AttendanceIntervals { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.VirtualEventExternalRegistrationInformation? ExternalRegistrationInformation { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.Identity? Identity { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MeetingAttendanceReportId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.AttendanceRecord();

    if (this.IsParameterBound(nameof(EmailAddress)))
        body.EmailAddress = EmailAddress;

    if (this.IsParameterBound(nameof(RegistrationId)))
        body.RegistrationId = RegistrationId;

    if (this.IsParameterBound(nameof(Role)))
        body.Role = Role;

    if (this.IsParameterBound(nameof(TotalAttendanceInSeconds)))
        body.TotalAttendanceInSeconds = TotalAttendanceInSeconds;

    if (this.IsParameterBound(nameof(AttendanceIntervals)))
        body.AttendanceIntervals = AttendanceIntervals!.ToList();

    if (this.IsParameterBound(nameof(ExternalRegistrationInformation)))
        body.ExternalRegistrationInformation = ExternalRegistrationInformation;

    if (this.IsParameterBound(nameof(Identity)))
        body.Identity = Identity;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.AttendanceRecord? result;
            try
            {
                result = client.Communications.OnlineMeetings[OnlineMeetingId].AttendanceReports[MeetingAttendanceReportId].AttendanceRecords.PostAsync(body, requestConfiguration =>
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
