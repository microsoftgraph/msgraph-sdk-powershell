### Example 1: Fetch attendee report of a Teams live event (deprecated)

```powershell
Import-Module Microsoft.Graph.CloudCommunications

# A UPN can also be used as -UserId.
Get-MgUserOnlineMeetingAttendeeReport -UserId $userId -OnlineMeetingId $onlineMeetingId
```
This example shows how to use the Get-MgUserOnlineMeetingAttendeeReport Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

