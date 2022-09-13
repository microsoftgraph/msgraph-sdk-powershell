###Example 1
```
Import-Module Microsoft.Graph.CloudCommunications
# A UPN can also be used as -UserId.
Get-MgUserOnlineMeetingAttendanceReport -UserId $userId -OnlineMeetingId $onlineMeetingId -MeetingAttendanceReportId $meetingAttendanceReportId -ExpandProperty "attendanceRecords" 
```
###Example 2
```
Import-Module Microsoft.Graph.CloudCommunications
# A UPN can also be used as -UserId.
Get-MgUserOnlineMeetingAttendanceReport -UserId $userId -OnlineMeetingId $onlineMeetingId
```
