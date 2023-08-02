### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

# A UPN can also be used as -UserId.
Get-MgBetaUserOnlineMeetingAttendanceReportAttendanceRecord -UserId $userId -OnlineMeetingId $onlineMeetingId -MeetingAttendanceReportId $meetingAttendanceReportId

```
This example shows how to use the Get-MgBetaUserOnlineMeetingAttendanceReportAttendanceRecord Cmdlet.

