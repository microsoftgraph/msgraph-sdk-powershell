### Example 1: Using the New-MgBetaUserMessageAttachmentUploadSession Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
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
New-MgBetaUserMessageAttachmentUploadSession -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserMessageAttachmentUploadSession Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaUserMessageAttachmentUploadSession Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	AttachmentItem = @{
		AttachmentType = "file"
		Name = "flower"
		Size = 3483322
	}
}
# A UPN can also be used as -UserId.
New-MgBetaUserMessageAttachmentUploadSession -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserMessageAttachmentUploadSession Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
