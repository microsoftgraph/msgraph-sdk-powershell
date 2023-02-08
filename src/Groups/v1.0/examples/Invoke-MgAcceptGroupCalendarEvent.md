### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Users.Actions

$params = @{
	Comment = "comment-value"
	SendResponse = $true
}

# A UPN can also be used as -UserId.
Invoke-MgAcceptUserEvent -UserId $userId -EventId $eventId -BodyParameter $params
```
This example shows how to use the Invoke-MgAcceptGroupCalendarEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

