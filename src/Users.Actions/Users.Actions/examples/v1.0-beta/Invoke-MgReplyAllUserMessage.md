### Example 1: Using the Invoke-MgReplyAllUserMessage Cmdlet
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
	Comment = "Please take a look at the attached guidelines before you decide on the name."
}
# A UPN can also be used as -UserId.
Invoke-MgReplyAllUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the Invoke-MgReplyAllUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
