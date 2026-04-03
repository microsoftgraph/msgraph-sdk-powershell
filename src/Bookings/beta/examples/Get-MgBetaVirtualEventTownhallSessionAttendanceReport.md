### Example 1: List attendance reports for a town hall session

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

Get-MgBetaVirtualEventTownhallSessionAttendanceReport -VirtualEventTownhallId $virtualEventTownhallId -VirtualEventSessionId $virtualEventSessionId

```
This example will list attendance reports for a town hall session

