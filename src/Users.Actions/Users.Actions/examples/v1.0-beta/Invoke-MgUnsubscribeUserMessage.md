### Example 1: Using the Invoke-MgBetaUnsubscribeUserMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
# A UPN can also be used as -UserId.
Invoke-MgBetaUnsubscribeUserMessage -UserId $userId -MessageId $messageId
```
This example shows how to use the Invoke-MgBetaUnsubscribeUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
