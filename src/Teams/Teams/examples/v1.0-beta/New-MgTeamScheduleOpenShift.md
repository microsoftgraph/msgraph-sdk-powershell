### Example 1: Using the New-MgBetaTeamScheduleOpenShift Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	Id = "OPNSHFT_577b75d2-a927-48c0-a5d1-dc984894e7b8"
	SchedulingGroupId = "TAG_228940ed-ff84-4e25-b129-1b395cf78be0"
	SharedOpenShift = @{
		Notes = "InventoryManagement"
		OpenSlotCount = 2
		DisplayName = "Dayshift"
		StartDateTime = [System.DateTime]::Parse("2018-10-04T00: 58: 45.340Z")
		EndDateTime = [System.DateTime]::Parse("2018-10-04T09: 50: 45.332Z")
		Theme = "white"
		Activities = @(
			@{
				IsPaid = $true
				StartDateTime = [System.DateTime]::Parse("2018-10-04T00: 58: 45.340Z")
				EndDateTime = [System.DateTime]::Parse("2018-10-04T01: 58: 45.340Z")
				Code = ""
				DisplayName = "Lunch"
			}
		)
	}
	DraftOpenShift = $null
	CreatedDateTime = [System.DateTime]::Parse("2019-03-14T04: 32: 51.451Z")
	LastModifiedDateTime = [System.DateTime]::Parse("2019-03-14T05: 32: 51.451Z")
	LastModifiedBy = @{
		Application = $null
		Device = $null
		Conversation = $null
		User = @{
			Id = "366c0b19-49b1-41b5-a03f-9f3887bd0ed8"
			DisplayName = "JohnDoe"
		}
	}
}
New-MgBetaTeamScheduleOpenShift -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamScheduleOpenShift Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
