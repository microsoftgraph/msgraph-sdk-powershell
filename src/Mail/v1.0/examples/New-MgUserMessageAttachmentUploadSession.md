### Example 1: Create an upload session to add a large attachment to a draft message

```powershell

Import-Module Microsoft.Graph.Mail

$params = @{
	AttachmentItem = @{
		attachmentType = "file"
		name = "flower"
		size = 3483322
	}
}

# A UPN can also be used as -UserId.
New-MgUserMessageAttachmentUploadSession -UserId $userId -MessageId $messageId -BodyParameter $params

```
This example will create an upload session to add a large attachment to a draft message

### Example 2: Create an upload session to add a large in-line attachment to a draft message

```powershell

Import-Module Microsoft.Graph.Mail

$params = @{
	AttachmentItem = @{
		attachmentType = "file"
		name = "scenary"
		size = 7208534
		isInline = $true
		contentId = "my_inline_picture"
	}
}

# A UPN can also be used as -UserId.
New-MgUserMessageAttachmentUploadSession -UserId $userId -MessageId $messageId -BodyParameter $params

```
This example will create an upload session to add a large in-line attachment to a draft message

