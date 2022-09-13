###Example 1
```
Import-Module Microsoft.Graph.CloudCommunications
# A UPN can also be used as -UserId.
Get-MgUserOnlineMeetingAttendanceReportAttendanceRecord -UserId $userId -OnlineMeetingId $onlineMeetingId -MeetingAttendanceReportId $meetingAttendanceReportId
```
