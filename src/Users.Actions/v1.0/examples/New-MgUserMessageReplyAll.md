### Example 1: Using the New-MgUserMessageReplyAll Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
# A UPN can also be used as -UserId.
New-MgUserMessageReplyAll -UserId $userId -MessageId $messageId
```
This example shows how to use the New-MgUserMessageReplyAll Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
