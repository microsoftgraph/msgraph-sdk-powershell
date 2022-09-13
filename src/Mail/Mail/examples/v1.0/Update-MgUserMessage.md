###Example 1
```
Import-Module Microsoft.Graph.Mail
$params = @{
	IsRead = $true
}
# A UPN can also be used as -UserId.
Update-MgUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params
```
###Example 2
```
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
