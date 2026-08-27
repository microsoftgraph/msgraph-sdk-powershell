#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.CloudCommunications.Client.Models;

namespace Microsoft.Graph.PowerShell.CloudCommunications
{
    [GraphRoute("GET", "/communications/onlineMeetings/{onlineMeeting-id}/attendanceReports/{meetingAttendanceReport-id}/attendanceRecords")]
    [Cmdlet(VerbsCommon.Get, "MgCommunicationOnlineMeetingAttendanceReportAttendanceRecord", DefaultParameterSetName = "List")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.AttendanceRecordCollectionResponse), ParameterSetName = new[] { "List" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.AttendanceRecord), ParameterSetName = new[] { "Get" })]
    public class GetMgCommunicationOnlineMeetingAttendanceReportAttendanceRecordCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OnlineMeetingId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MeetingAttendanceReportId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, ParameterSetName = "Get", Position = 2)]
        public string AttendanceRecordId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }

        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "List")]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "List")]
        [Alias("OrderBy")]
        public string[]? Sort { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "List")]
        public string? Search { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "List")]
        public int Top { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "List")]
        public int Skip { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "List")]
        public SwitchParameter Count { get; set; }





        // Delegates to Get-MgCommunicationOnlineMeetingAttendanceReportAttendanceRecord_Get or Get-MgCommunicationOnlineMeetingAttendanceReportAttendanceRecord_List, the two cmdlets
        // that actually call Graph.
        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName == "Get" ? "Get-MgCommunicationOnlineMeetingAttendanceReportAttendanceRecord_Get" : "Get-MgCommunicationOnlineMeetingAttendanceReportAttendanceRecord_List";
            try
            {
                InvokeCommand.InvokeScript(
                    "param($BoundParameters, $CmdletName) & $CmdletName @BoundParameters",
                    false,
                    PipelineResultTypes.Output | PipelineResultTypes.Error,
                    null,
                    MyInvocation.BoundParameters, internalCmdletName);
            }
            // The workers signal failure via ThrowTerminatingError, which InvokeScript surfaces
            // as a RuntimeException carrying the worker's ErrorRecord. Rethrow that record
            // unchanged so the caller sees the worker's error identity (NoGraphSession,
            // GraphRequestFailed, ...) instead of every failure collapsing into a generic
            // dispatcher error.
            catch (RuntimeException rex) when (rex.ErrorRecord is not null)
            {
                ThrowTerminatingError(rex.ErrorRecord);
                return;
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ParameterSetName == "Get" ? AttendanceRecordId : MeetingAttendanceReportId);
                return;
            }
        }
    }
}
