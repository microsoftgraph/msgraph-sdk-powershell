### Example 1
``` powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	StartDateTime = [System.DateTime]::Parse("2019-07-12T14:30:34.2444915-07:00")
	EndDateTime = [System.DateTime]::Parse("2019-07-12T15:00:34.2464912-07:00")
	Subject = "User Token Meeting"
}
# A UPN can also be used as -UserId.
New-MgUserOnlineMeeting -UserId $userId -BodyParameter $params
```
