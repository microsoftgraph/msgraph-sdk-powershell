### Example 1: Update the startDateTime, endDateTime and subject

```powershellImport-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	startDateTime = [System.DateTime]::Parse("2020-09-09T14:33:30.8546353-07:00")
	endDateTime = [System.DateTime]::Parse("2020-09-09T15:03:30.8566356-07:00")
	subject = "Patch Meeting Subject"
}

# A UPN can also be used as -UserId.
Update-MgBetaUserOnlineMeeting -UserId $userId -OnlineMeetingId $onlineMeetingId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserOnlineMeeting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

