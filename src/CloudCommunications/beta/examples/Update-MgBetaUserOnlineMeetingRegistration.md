### Example 1: Using the Update-MgBetaUserOnlineMeetingRegistration Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	Subject = "Microsoft Ignite: Day 1"
	StartDateTime = [System.DateTime]::Parse("2021-11-02T08:00:00-08:00")
	EndDateTime = [System.DateTime]::Parse("2021-11-02T15:45:00-08:00")
	Speakers = @(
		@{
			DisplayName = "Henry Ross"
			Bio = "Chairman and Chief Executive Officer"
		}
		@{
			DisplayName = "Fred Ryan"
			Bio = "CVP"
		}
	)
}
# A UPN can also be used as -UserId.
Update-MgBetaUserOnlineMeetingRegistration -UserId $userId -OnlineMeetingId $onlineMeetingId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserOnlineMeetingRegistration Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
