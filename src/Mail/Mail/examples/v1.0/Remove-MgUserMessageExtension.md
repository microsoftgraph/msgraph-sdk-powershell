### Example 1: Using the Remove-MgUserMessageExtension Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Remove-MgUserMessageExtension -UserId $userId -MessageId $messageId -ExtensionId $extensionId
```
This example shows how to use the Remove-MgUserMessageExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
