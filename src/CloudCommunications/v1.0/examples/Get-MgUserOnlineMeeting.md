### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.CloudCommunications

# A UPN can also be used as -UserId.
Remove-MgUserOnlineMeeting -UserId $userId -OnlineMeetingId $onlineMeetingId
```
This example shows how to use the Get-MgUserOnlineMeeting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

