### Example 1: Update a schedule

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	enabled = $true
	timeZone = "America/Chicago"
}

Set-MgBetaTeamSchedule -TeamId $teamId -BodyParameter $params

```
This example will update a schedule

### Example 2: Enable location detection for time clock

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	enabled = $true
	timeZone = "America/Chicago"
	provisionStatus = "Completed"
	provisionStatusCode = $null
	openShiftsEnabled = $true
	swapShiftsRequestsEnabled = $true
	offerShiftRequestsEnabled = $true
	timeOffRequestsEnabled = $true
	startDayOfWeek = "Tuesday"
	isActivitiesIncludedWhenCopyingShiftsEnabled = $true
	isCrossLocationShiftsEnabled = $true
	isCrossLocationShiftRequestApprovalRequired = $true
	timeClockEnabled = $true
}

Set-MgBetaTeamSchedule -TeamId $teamId -BodyParameter $params

```
This example will enable location detection for time clock

