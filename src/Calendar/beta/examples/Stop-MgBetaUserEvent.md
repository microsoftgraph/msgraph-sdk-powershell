### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	Comment = "Cancelling for this week due to all hands"
}

# A UPN can also be used as -UserId.
Stop-MgBetaUserEvent -UserId $userId -EventId $eventId -BodyParameter $params

```
This example shows how to use the Stop-MgBetaUserEvent Cmdlet.

