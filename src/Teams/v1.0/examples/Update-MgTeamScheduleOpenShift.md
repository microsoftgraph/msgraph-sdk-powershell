### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

$params = @{
	schedulingGroupId = "TAG_228940ed-ff84-4e25-b129-1b395cf78be0"
	sharedOpenShift = @{
		notes = "Inventory Management"
		openSlotCount = 5
		displayName = "Field shift"
		startDateTime = [System.DateTime]::Parse("2018-10-04T00:58:45.340Z")
		endDateTime = [System.DateTime]::Parse("2018-10-04T09:50:45.332Z")
		theme = "white"
		activities = @(
			@{
				isPaid = $true
				startDateTime = [System.DateTime]::Parse("2018-10-04T00:58:45.340Z")
				endDateTime = [System.DateTime]::Parse("2018-10-04T01:58:45.340Z")
				code = ""
				displayName = "Lunch"
			}
		)
	}
	draftOpenShift = $null
}

Update-MgTeamScheduleOpenShift -TeamId $teamId -OpenShiftId $openShiftId -BodyParameter $params
```
This example shows how to use the Update-MgTeamScheduleOpenShift Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

