### Example 1
``` powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	AttachmentItem = @{
		AttachmentType = "file"
		Name = "scenary"
		Size = 7208534
		IsInline = $true
		ContentId = "my_inline_picture"
	}
}
# A UPN can also be used as -UserId.
New-MgUserMessageAttachmentUploadSession -UserId $userId -MessageId $messageId -BodyParameter $params
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	AttachmentItem = @{
		AttachmentType = "file"
		Name = "flower"
		Size = 3483322
	}
}
# A UPN can also be used as -UserId.
New-MgUserMessageAttachmentUploadSession -UserId $userId -MessageId $messageId -BodyParameter $params
```
