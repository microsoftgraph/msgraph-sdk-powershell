### Example 1: Using the Update-MgUserMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
$params = @{
	IsRead = "true"
}
# A UPN can also be used as -UserId.
Update-MgUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the Update-MgUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgUserMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
$params = @{
	Subject = "subject-value"
	Body = @{
		ContentType = ""
		Content = "content-value"
	}
	InferenceClassification = "other"
}
# A UPN can also be used as -UserId.
Update-MgUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the Update-MgUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
