### Example 1: Using the Invoke-MgUnsubscribeUserMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
# A UPN can also be used as -UserId.
Invoke-MgUnsubscribeUserMessage -UserId $userId -MessageId $messageId
```
This example shows how to use the Invoke-MgUnsubscribeUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
