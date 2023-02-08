### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	Comment = "comment-value"
	SendResponse = $true
}

# A UPN can also be used as -UserId.
Invoke-MgBetaAcceptUserEvent -UserId $userId -EventId $eventId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaAcceptGroupCalendarEvent Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

