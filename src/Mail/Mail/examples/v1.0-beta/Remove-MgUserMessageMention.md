### Example 1: Using the Remove-MgUserMessageMention Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Remove-MgUserMessageMention -UserId $userId -MessageId $messageId -MentionId $mentionId
```
This example shows how to use the Remove-MgUserMessageMention Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
