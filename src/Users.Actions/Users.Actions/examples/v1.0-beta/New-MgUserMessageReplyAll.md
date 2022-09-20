### Example 1: Using the New-MgUserMessageReplyAll Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	Message = @{
		Attachments = @(
			@{
				"@odata.type" = "#microsoft.graph.fileAttachment"
				Name = "guidelines.txt"
				ContentBytes = "bWFjIGFuZCBjaGVlc2UgdG9kYXk="
			}
		)
	}
	Comment = "if the project gets approved, please take a look at the attached guidelines before you decide on the name."
}
# A UPN can also be used as -UserId.
New-MgUserMessageReplyAll -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the New-MgUserMessageReplyAll Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
