### Example 1
```powershell
Import-Module Microsoft.Graph.Mail
$params = @{
	IsRead = $true
}
# A UPN can also be used as -UserId.
Update-MgUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params
```
### Example 2
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
