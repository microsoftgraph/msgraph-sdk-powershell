###Example 1
```
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	Comment = "comment-value"
	SendResponse = $true
}
# A UPN can also be used as -UserId.
Invoke-MgAcceptUserEvent -UserId $userId -EventId $eventId -BodyParameter $params
```
