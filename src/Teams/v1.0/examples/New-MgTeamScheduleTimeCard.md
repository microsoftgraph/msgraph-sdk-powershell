### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	userId = "d56f3e8a-2b0f-42b1-88b9-e2dbd12a34d2"
	clockInEvent = @{
		dateTime = [System.DateTime]::Parse("2025-01-07T21:00:00.000Z")
		isAtApprovedLocation = $true
		notes = @{
			content = "Started late due to traffic in CA 237"
			contentType = "text"
		}
	}
	clockOutEvent = @{
		dateTime = [System.DateTime]::Parse("2025-01-07T21:30:00.000Z")
		isAtApprovedLocation = $true
	}
}

New-MgTeamScheduleTimeCard -TeamId $teamId -BodyParameter $params

```
This example shows how to use the New-MgTeamScheduleTimeCard Cmdlet.

