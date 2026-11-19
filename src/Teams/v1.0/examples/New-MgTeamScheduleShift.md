### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	userId = "5ca83ce7-291d-43b7-bf53-af79eef4bc1d"
	draftShift = @{
		displayName = $null
		startDateTime = [System.DateTime]::Parse("2024-10-08T15:00:00Z")
		endDateTime = [System.DateTime]::Parse("2024-10-09T00:00:00Z")
		theme = "blue"
		notes = $null
		activities = @(
		)
	}
	sharedShift = $null
	isStagedForDeletion = $false
}

New-MgTeamScheduleShift -TeamId $teamId -BodyParameter $params

```
This example shows how to use the New-MgTeamScheduleShift Cmdlet.

