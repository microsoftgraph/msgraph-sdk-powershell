### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Calendar

$params = @{
	location = @{
		displayName = "Conf Room 2"
	}
}

Update-MgGroupCalendarEvent -GroupId $groupId -EventId $eventId -BodyParameter $params

```
This example shows how to use the Update-MgGroupCalendarEvent Cmdlet.

