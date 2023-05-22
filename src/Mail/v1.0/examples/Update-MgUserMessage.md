### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Mail

$params = @{
	subject = "subject-value"
	body = @{
		contentType = ""
		content = "content-value"
	}
	inferenceClassification = "other"
}

# A UPN can also be used as -UserId.
Update-MgUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the Update-MgUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

