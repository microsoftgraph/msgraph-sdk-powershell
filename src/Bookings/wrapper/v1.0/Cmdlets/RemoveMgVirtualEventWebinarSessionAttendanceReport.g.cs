#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Bookings.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Bookings
{
    [GraphRoute("DELETE", "/solutions/virtualEvents/webinars/{virtualEventWebinar-id}/sessions/{virtualEventSession-id}/attendanceReports/{meetingAttendanceReport-id}")]
    [Cmdlet(VerbsCommon.Remove, "MgVirtualEventWebinarSessionAttendanceReport", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public class RemoveMgVirtualEventWebinarSessionAttendanceReportCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string VirtualEventWebinarId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string VirtualEventSessionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string MeetingAttendanceReportId { get; set; } = string.Empty;


        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'If-Match' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? IfMatch { get; set; }




        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MeetingAttendanceReportId, "Remove"))
                return;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            // DeleteAsync returns a plain Task: a standard delete response has no body.
            try
            {
                client.Solutions.VirtualEvents.Webinars[VirtualEventWebinarId].Sessions[VirtualEventSessionId].AttendanceReports[MeetingAttendanceReportId].DeleteAsync(requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(IfMatch)))
                            requestConfiguration.Headers.Add("If-Match", IfMatch!);

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, MeetingAttendanceReportId);
                return;
            }
        }
    }
}
