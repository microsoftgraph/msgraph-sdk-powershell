### Example 1: List attendance records for the attendance report of a town hall session

```powershell

Import-Module Microsoft.Graph.Bookings

Get-MgVirtualEventTownhallSessionAttendanceReportAttendanceRecord -VirtualEventTownhallId $virtualEventTownhallId -VirtualEventSessionId $virtualEventSessionId -MeetingAttendanceReportId $meetingAttendanceReportId

```
This example will list attendance records for the attendance report of a town hall session

