### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Mail

$params = @{
	message = @{
		attachments = @(
			@{
				"@odata.type" = "#microsoft.graph.fileAttachment"
				name = "guidelines.txt"
				contentBytes = "bWFjIGFuZCBjaGVlc2UgdG9kYXk="
			}
		)
	}
	comment = "if the project gets approved, please take a look at the attached guidelines before you decide on the name."
}

# A UPN can also be used as -UserId.
New-MgBetaUserMessageReplyAll -UserId $userId -MessageId $messageId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserMessageReplyAll Cmdlet.

