### Example 1: Using the Invoke-MgBetaAcceptUserEventTentatively Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	Comment = "I may not be able to make this week. How about next week?"
	SendResponse = $true
	ProposedNewTime = @{
		Start = @{
			DateTime = "2019-12-02T18:00:00"
			TimeZone = "Pacific Standard Time"
		}
		End = @{
			DateTime = "2019-12-02T19:00:00"
			TimeZone = "Pacific Standard Time"
		}
	}
}
# A UPN can also be used as -UserId.
Invoke-MgBetaAcceptUserEventTentatively -UserId $userId -EventId $eventId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaAcceptUserEventTentatively Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
