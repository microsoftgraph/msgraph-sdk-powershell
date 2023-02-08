### Example 1: Using the Update-MgBetaUserProfileProject Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	AllowedAudiences = "organization"
	Client = @{
		Department = "Corporate Marketing"
		WebUrl = "https://www.contoso.com"
	}
}
# A UPN can also be used as -UserId.
Update-MgBetaUserProfileProject -UserId $userId -ProjectParticipationId $projectParticipationId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserProfileProject Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
