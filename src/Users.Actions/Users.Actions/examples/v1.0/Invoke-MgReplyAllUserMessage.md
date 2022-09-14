### Example 1
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	Comment = "comment-value"
}
# A UPN can also be used as -UserId.
Invoke-MgReplyAllUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params
```
