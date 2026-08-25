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
    [GraphRoute("PATCH", "/solutions/virtualEvents/webinars/{virtualEventWebinar-id}/sessions/{virtualEventSession-id}/attendanceReports/{meetingAttendanceReport-id}/attendanceRecords/{attendanceRecord-id}")]
    [Cmdlet(VerbsData.Update, "MgVirtualEventWebinarSessionAttendanceReportAttendanceRecord", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Bookings.Client.Models.AttendanceRecord))]
    public class UpdateMgVirtualEventWebinarSessionAttendanceReportAttendanceRecordCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string VirtualEventWebinarId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string VirtualEventSessionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string MeetingAttendanceReportId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string AttendanceRecordId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? EmailAddress { get; set; }

        [Parameter(Mandatory = false)]
        public string? RegistrationId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Role { get; set; }

        [Parameter(Mandatory = false)]
        public int? TotalAttendanceInSeconds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.AttendanceInterval[]? AttendanceIntervals { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventExternalRegistrationInformation? ExternalRegistrationInformation { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.Identity? Identity { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AttendanceRecordId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Bookings.Client.Models.AttendanceRecord();

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

            Microsoft.Graph.PowerShell.Bookings.Client.Models.AttendanceRecord? result;
            try
            {
                result = client.Solutions.VirtualEvents.Webinars[VirtualEventWebinarId].Sessions[VirtualEventSessionId].AttendanceReports[MeetingAttendanceReportId].AttendanceRecords[AttendanceRecordId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, AttendanceRecordId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Solutions.VirtualEvents.Webinars[VirtualEventWebinarId].Sessions[VirtualEventSessionId].AttendanceReports[MeetingAttendanceReportId].AttendanceRecords[AttendanceRecordId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, AttendanceRecordId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
