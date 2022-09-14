### Example 1
``` powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	DestinationId = "deleteditems"
}
# A UPN can also be used as -UserId.
Move-MgUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params
```
