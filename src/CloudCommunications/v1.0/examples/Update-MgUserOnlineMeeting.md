### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.CloudCommunications

$params = @{
	startDateTime = [System.DateTime]::Parse("2020-09-09T14:33:30.8546353-07:00")
	endDateTime = [System.DateTime]::Parse("2020-09-09T15:03:30.8566356-07:00")
	subject = "Patch Meeting Subject"
}

# A UPN can also be used as -UserId.
Update-MgUserOnlineMeeting -UserId $userId -OnlineMeetingId $onlineMeetingId -BodyParameter $params
```
This example shows how to use the Update-MgUserOnlineMeeting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.CloudCommunications

$params = @{
	lobbyBypassSettings = @{
		isDialInBypassEnabled = $true
	}
}

# A UPN can also be used as -UserId.
Update-MgUserOnlineMeeting -UserId $userId -OnlineMeetingId $onlineMeetingId -BodyParameter $params
```
This example shows how to use the Update-MgUserOnlineMeeting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

