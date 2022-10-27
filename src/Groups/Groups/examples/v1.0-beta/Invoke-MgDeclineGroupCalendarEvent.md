### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Users.Actions

$params = @{
	Comment = "I won't be able to make this week. How about next week?"
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
Invoke-MgDeclineUserEvent -UserId $userId -EventId $eventId -BodyParameter $params
```
This example shows how to use the Invoke-MgDeclineGroupCalendarEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

