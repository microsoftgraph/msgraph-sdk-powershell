### Example 1: Using the New-MgBetaUserOnlineMeeting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	StartDateTime = [System.DateTime]::Parse("2019-07-12T14:30:34.2444915-07:00")
	EndDateTime = [System.DateTime]::Parse("2019-07-12T15:00:34.2464912-07:00")
	Subject = "User Token Meeting"
}
# A UPN can also be used as -UserId.
New-MgBetaUserOnlineMeeting -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserOnlineMeeting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
