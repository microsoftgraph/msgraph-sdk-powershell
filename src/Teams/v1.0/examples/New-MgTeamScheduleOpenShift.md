### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	schedulingGroupId = "TAG_4ab7d329-1f7e-4eaf-ba93-63f1ff3f3c4a"
	sharedOpenShift = @{
		displayName = "Dayshift"
		startDateTime = [System.DateTime]::Parse("2024-11-04T20:00:00Z")
		endDateTime = [System.DateTime]::Parse("2024-11-04T21:00:00Z")
		theme = "blue"
		notes = "InventoryManagement"
		openSlotCount = 1
		activities = @(
		)
	}
	draftTimeOff = $null
	isStagedForDeletion = $false
}

New-MgTeamScheduleOpenShift -TeamId $teamId -BodyParameter $params

```
This example shows how to use the New-MgTeamScheduleOpenShift Cmdlet.

