### Example 1: Fetch attendee report of a Teams live event

```powershell

Import-Module Microsoft.Graph.CloudCommunications

# A UPN can also be used as -UserId.
Get-MgUserOnlineMeetingAttendeeReport -UserId $userId -OnlineMeetingId $onlineMeetingId

```
This example will fetch attendee report of a teams live event

