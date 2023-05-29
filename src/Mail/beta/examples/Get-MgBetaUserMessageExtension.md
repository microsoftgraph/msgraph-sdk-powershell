### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Mail

# A UPN can also be used as -UserId.
Get-MgBetaUserMessageExtension -UserId $userId -MessageId $messageId -ExtensionId $extensionId
```
This example shows how to use the Get-MgBetaUserMessageExtension Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

