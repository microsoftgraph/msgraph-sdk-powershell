### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications

Get-MgBetaUserOnlineMeeting -UserId $userId -Filter "joinMeetingIdSettings/joinMeetingId eq '1234567890'"
```
This example shows how to use the Get-MgBetaUserOnlineMeeting Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

