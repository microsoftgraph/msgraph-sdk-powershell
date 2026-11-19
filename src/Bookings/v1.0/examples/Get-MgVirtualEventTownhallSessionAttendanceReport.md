### Example 1: Get the attendance report for a town hall session by ID

```powershell

Import-Module Microsoft.Graph.Bookings

Get-MgVirtualEventTownhallSessionAttendanceReport -VirtualEventTownhallId $virtualEventTownhallId -VirtualEventSessionId $virtualEventSessionId -MeetingAttendanceReportId $meetingAttendanceReportId

```
This example will get the attendance report for a town hall session by id

