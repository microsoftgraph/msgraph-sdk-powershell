### Example 1: Using the Remove-MgBetaUserOnlineMeeting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
# A UPN can also be used as -UserId.
Remove-MgBetaUserOnlineMeeting -UserId $userId -OnlineMeetingId $onlineMeetingId
```
This example shows how to use the Remove-MgBetaUserOnlineMeeting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
