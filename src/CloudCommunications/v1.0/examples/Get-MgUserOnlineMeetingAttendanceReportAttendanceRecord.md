### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.CloudCommunications

# A UPN can also be used as -UserId.
Get-MgUserOnlineMeetingAttendanceReportAttendanceRecord -UserId $userId -OnlineMeetingId $onlineMeetingId -MeetingAttendanceReportId $meetingAttendanceReportId

```
This example shows how to use the Get-MgUserOnlineMeetingAttendanceReportAttendanceRecord Cmdlet.

