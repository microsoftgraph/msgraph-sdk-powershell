### Example 1: Using the New-MgUserMessageForward Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
# A UPN can also be used as -UserId.
New-MgUserMessageForward -UserId $userId -MessageId $messageId
```
This example shows how to use the New-MgUserMessageForward Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
