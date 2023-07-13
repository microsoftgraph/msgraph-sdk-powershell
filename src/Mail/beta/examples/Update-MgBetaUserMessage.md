### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Mail

$params = @{
	isRead = "true"
}

# A UPN can also be used as -UserId.
Update-MgBetaUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

