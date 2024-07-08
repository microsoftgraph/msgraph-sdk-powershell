### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	comment = "I won't be able to make this week. How about next week?"
	sendResponse = $true
	proposedNewTime = @{
		start = @{
			dateTime = "2019-12-02T18:00:00"
			timeZone = "Pacific Standard Time"
		}
		end = @{
			dateTime = "2019-12-02T19:00:00"
			timeZone = "Pacific Standard Time"
		}
	}
}

# A UPN can also be used as -UserId.
Invoke-MgBetaDeclineUserEvent -UserId $userId -EventId $eventId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaDeclineUserEvent Cmdlet.

