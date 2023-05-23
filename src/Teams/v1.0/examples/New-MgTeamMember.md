### Example 1: Add a member to a team

```powershellImport-Module Microsoft.Graph.Teams

$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	roles = @(
		"owner"
	)
	"user@odata.bind" = "https://graph.microsoft.com/v1.0/users('8b081ef6-4792-4def-b2c9-c363a1bf41d5')"
}

New-MgTeamMember -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgTeamMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Add a member to a team using user principal name

```powershellImport-Module Microsoft.Graph.Teams

$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	roles = @(
		"owner"
	)
	"user@odata.bind" = "https://graph.microsoft.com/v1.0/users('jacob@contoso.com')"
}

New-MgTeamMember -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgTeamMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

