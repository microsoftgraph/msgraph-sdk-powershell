### Example 1: Using the New-MgBetaTeamMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
		"owner"
	)
	"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('8b081ef6-4792-4def-b2c9-c363a1bf41d5')"
}
New-MgBetaTeamMember -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaTeamMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
		"owner"
	)
	"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('jacob@contoso.com')"
}
New-MgBetaTeamMember -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
