### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	id = "OPNSHFT_577b75d2-a927-48c0-a5d1-dc984894e7b8"
	schedulingGroupId = "TAG_228940ed-ff84-4e25-b129-1b395cf78be0"
	sharedOpenShift = @{
		notes = "InventoryManagement"
		openSlotCount = 2
		displayName = "Dayshift"
		startDateTime = [System.DateTime]::Parse("2018-10-04T00: 58: 45.340Z")
		endDateTime = [System.DateTime]::Parse("2018-10-04T09: 50: 45.332Z")
		theme = "white"
		activities = @(
			@{
				isPaid = $true
				startDateTime = [System.DateTime]::Parse("2018-10-04T00: 58: 45.340Z")
				endDateTime = [System.DateTime]::Parse("2018-10-04T01: 58: 45.340Z")
				code = ""
				displayName = "Lunch"
			}
		)
	}
	draftOpenShift = $null
	createdDateTime = [System.DateTime]::Parse("2019-03-14T04: 32: 51.451Z")
	lastModifiedDateTime = [System.DateTime]::Parse("2019-03-14T05: 32: 51.451Z")
	lastModifiedBy = @{
		application = $null
		device = $null
		conversation = $null
		user = @{
			id = "366c0b19-49b1-41b5-a03f-9f3887bd0ed8"
			displayName = "JohnDoe"
		}
	}
}

New-MgTeamScheduleOpenShift -TeamId $teamId -BodyParameter $params

```
This example shows how to use the New-MgTeamScheduleOpenShift Cmdlet.

