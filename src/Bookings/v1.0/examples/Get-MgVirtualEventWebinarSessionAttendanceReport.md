### Example 1: Get the attendance report for a webinar session by ID

```powershell

Import-Module Microsoft.Graph.Bookings

Get-MgVirtualEventWebinarSessionAttendanceReport -VirtualEventWebinarId $virtualEventWebinarId -VirtualEventSessionId $virtualEventSessionId -MeetingAttendanceReportId $meetingAttendanceReportId

```
This example will get the attendance report for a webinar session by id

