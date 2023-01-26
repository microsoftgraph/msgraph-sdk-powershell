### Example 1: Using the Get-MgBetaUserOnlineMeetingAttendanceReportAttendanceRecord Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
# A UPN can also be used as -UserId.
Get-MgBetaUserOnlineMeetingAttendanceReportAttendanceRecord -UserId $userId -OnlineMeetingId $onlineMeetingId -MeetingAttendanceReportId $meetingAttendanceReportId
```
This example shows how to use the Get-MgBetaUserOnlineMeetingAttendanceReportAttendanceRecord Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
