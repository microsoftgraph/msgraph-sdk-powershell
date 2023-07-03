### Example 1: Using the Remove-MgBetaUserMessageMention Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Mail
# A UPN can also be used as -UserId.
Remove-MgBetaUserMessageMention -UserId $userId -MessageId $messageId -MentionId $mentionId
```
This example shows how to use the Remove-MgBetaUserMessageMention Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
