### Example 1: Create an upload session to add a large attachment to a draft message

```powershellImport-Module Microsoft.Graph.Users.Actions

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
This example shows how to use the New-MgGroupConversationThreadPostInReplyToAttachmentUploadSession Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Create an upload session to add a large in-line attachment to a draft message

```powershellImport-Module Microsoft.Graph.Users.Actions

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
This example shows how to use the New-MgGroupConversationThreadPostInReplyToAttachmentUploadSession Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

