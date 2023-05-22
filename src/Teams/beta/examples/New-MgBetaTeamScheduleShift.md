### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	id = "SHFT_577b75d2-a927-48c0-a5d1-dc984894e7b8"
	userId = "c5d0c76b-80c4-481c-be50-923cd8d680a1"
	schedulingGroupId = "TAG_228940ed-ff84-4e25-b129-1b395cf78be0"
	sharedShift = @{
		displayName = "Day shift"
		notes = "Please do inventory as part of your shift."
		startDateTime = [System.DateTime]::Parse("2019-03-11T15:00:00Z")
		endDateTime = [System.DateTime]::Parse("2019-03-12T00:00:00Z")
		theme = "blue"
		activities = @(
			@{
				isPaid = $true
				startDateTime = [System.DateTime]::Parse("2019-03-11T15:00:00Z")
				endDateTime = [System.DateTime]::Parse("2019-03-11T15:15:00Z")
				code = ""
				displayName = "Lunch"
			}
		)
	}
	draftShift = @{
		displayName = "Day shift"
		notes = "Please do inventory as part of your shift."
		startDateTime = [System.DateTime]::Parse("2019-03-11T15:00:00Z")
		endDateTime = [System.DateTime]::Parse("2019-03-12T00:00:00Z")
		theme = "blue"
		activities = @(
			@{
				isPaid = $true
				startDateTime = [System.DateTime]::Parse("2019-03-11T15:00:00Z")
				endDateTime = [System.DateTime]::Parse("2019-03-11T15:30:00Z")
				code = ""
				displayName = "Lunch"
			}
		)
	}
}

New-MgBetaTeamScheduleShift -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaTeamScheduleShift Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

