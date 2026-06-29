### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Mail

$params = @{
	comment = "comment-value"
}

# A UPN can also be used as -UserId.
Invoke-MgReplyAllUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params

```
This example shows how to use the Invoke-MgReplyAllUserMessage Cmdlet.

