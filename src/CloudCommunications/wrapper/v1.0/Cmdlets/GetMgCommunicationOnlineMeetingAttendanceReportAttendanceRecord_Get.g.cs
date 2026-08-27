#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.CloudCommunications.Client;
using Microsoft.Graph.PowerShell.CloudCommunications.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.CloudCommunications
{
    [GraphRoute("GET", "/communications/onlineMeetings/{onlineMeeting-id}/attendanceReports/{meetingAttendanceReport-id}/attendanceRecords/{attendanceRecord-id}")]
    [Cmdlet(VerbsCommon.Get, "MgCommunicationOnlineMeetingAttendanceReportAttendanceRecord_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.AttendanceRecord))]
    public class GetMgCommunicationOnlineMeetingAttendanceReportAttendanceRecord_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OnlineMeetingId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MeetingAttendanceReportId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string AttendanceRecordId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.AttendanceRecord? result;
            try
            {
                result = client.Communications.OnlineMeetings[OnlineMeetingId].AttendanceReports[MeetingAttendanceReportId].AttendanceRecords[AttendanceRecordId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, AttendanceRecordId);
                return;
            }

            WriteObject(result);
        }
    }
}
