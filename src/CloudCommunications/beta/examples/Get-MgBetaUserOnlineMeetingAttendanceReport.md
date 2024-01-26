### Example 1: Get the attendance report for an online meeting by ID

```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications

# A UPN can also be used as -UserId.
Get-MgBetaUserOnlineMeetingAttendanceReport -UserId $userId -OnlineMeetingId $onlineMeetingId -MeetingAttendanceReportId $meetingAttendanceReportId -ExpandProperty "attendanceRecords"
```
This example shows how to use the Get-MgBetaUserOnlineMeetingAttendanceReport Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

