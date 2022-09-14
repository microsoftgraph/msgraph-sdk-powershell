### Example 1: Using the Get-MgUserOnlineMeetingAttendanceReportAttendanceRecord Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
# A UPN can also be used as -UserId.
Get-MgUserOnlineMeetingAttendanceReportAttendanceRecord -UserId $userId -OnlineMeetingId $onlineMeetingId -MeetingAttendanceReportId $meetingAttendanceReportId
```
This example shows how to use the Get-MgUserOnlineMeetingAttendanceReportAttendanceRecord Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
