### Example 1: Using the Update-MgBetaUserOnlineMeeting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	LobbyBypassSettings = @{
		IsDialInBypassEnabled = $true
	}
}
# A UPN can also be used as -UserId.
Update-MgBetaUserOnlineMeeting -UserId $userId -OnlineMeetingId $onlineMeetingId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserOnlineMeeting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgBetaUserOnlineMeeting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	StartDateTime = [System.DateTime]::Parse("2020-09-09T14:33:30.8546353-07:00")
	EndDateTime = [System.DateTime]::Parse("2020-09-09T15:03:30.8566356-07:00")
	Subject = "Patch Meeting Subject"
}
# A UPN can also be used as -UserId.
Update-MgBetaUserOnlineMeeting -UserId $userId -OnlineMeetingId $onlineMeetingId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserOnlineMeeting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
