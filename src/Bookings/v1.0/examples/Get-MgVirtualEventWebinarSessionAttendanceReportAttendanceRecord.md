### Example 1: List attendance records of a webinar session's attendance report

```powershell

Import-Module Microsoft.Graph.Bookings

Get-MgVirtualEventWebinarSessionAttendanceReportAttendanceRecord -VirtualEventWebinarId $virtualEventWebinarId -VirtualEventSessionId $virtualEventSessionId -MeetingAttendanceReportId $meetingAttendanceReportId

```
This example will list attendance records of a webinar session's attendance report

