###Example 1
```
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	Comment = "comment-value"
}
# A UPN can also be used as -UserId.
Invoke-MgReplyAllUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params
```
