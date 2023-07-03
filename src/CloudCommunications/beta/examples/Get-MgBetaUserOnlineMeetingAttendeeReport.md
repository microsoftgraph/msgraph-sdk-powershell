### Example 1: Fetch attendee report of a Teams live event

```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications

# A UPN can also be used as -UserId.
Get-MgBetaUserOnlineMeetingAttendeeReport -UserId $userId -OnlineMeetingId $onlineMeetingId
```
This example shows how to use the Get-MgBetaUserOnlineMeetingAttendeeReport Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

