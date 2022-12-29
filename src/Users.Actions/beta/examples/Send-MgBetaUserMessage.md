### Example 1: Using the Send-MgBetaUserMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
# A UPN can also be used as -UserId.
Send-MgBetaUserMessage -UserId $userId -MessageId $messageId
```
This example shows how to use the Send-MgBetaUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
