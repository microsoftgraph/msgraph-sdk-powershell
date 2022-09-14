### Example 1
``` powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	LobbyBypassSettings = @{
		IsDialInBypassEnabled = $true
	}
}
# A UPN can also be used as -UserId.
Update-MgUserOnlineMeeting -UserId $userId -OnlineMeetingId $onlineMeetingId -BodyParameter $params
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	StartDateTime = [System.DateTime]::Parse("2020-09-09T14:33:30.8546353-07:00")
	EndDateTime = [System.DateTime]::Parse("2020-09-09T15:03:30.8566356-07:00")
	Subject = "Patch Meeting Subject"
}
# A UPN can also be used as -UserId.
Update-MgUserOnlineMeeting -UserId $userId -OnlineMeetingId $onlineMeetingId -BodyParameter $params
```
