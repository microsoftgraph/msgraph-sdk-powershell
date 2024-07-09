### Example 1: List attendance reports for a webinar session

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

Get-MgBetaVirtualEventWebinarSessionAttendanceReport -VirtualEventWebinarId $virtualEventWebinarId -VirtualEventSessionId $virtualEventSessionId

```
This example will list attendance reports for a webinar session

