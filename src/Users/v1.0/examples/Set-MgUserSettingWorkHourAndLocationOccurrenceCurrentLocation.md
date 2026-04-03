### Example 1: Set the current location to office

```powershell

Import-Module Microsoft.Graph.Users

$params = @{
	updateScope = "currentDay"
	workLocationType = "office"
	placeId = "12345678-1234-1234-1234-123456789012"
}

# A UPN can also be used as -UserId.
Set-MgUserSettingWorkHourAndLocationOccurrenceCurrentLocation -UserId $userId -BodyParameter $params

```
This example will set the current location to office

### Example 2: Set current location to remote

```powershell

Import-Module Microsoft.Graph.Users

$params = @{
	updateScope = "currentSegment"
	workLocationType = "remote"
}

# A UPN can also be used as -UserId.
Set-MgUserSettingWorkHourAndLocationOccurrenceCurrentLocation -UserId $userId -BodyParameter $params

```
This example will set current location to remote

