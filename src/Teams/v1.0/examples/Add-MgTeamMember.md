### Example 1: Using the Add-MgTeamMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	Values = @(
		@{
			"@odata.type" = "microsoft.graph.aadUserConversationMember"
			Roles = @(
			)
			"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('18a80140-b0fb-4489-b360-2f6efaf225a0')"
		}
		@{
			"@odata.type" = "microsoft.graph.aadUserConversationMember"
			Roles = @(
				"owner"
			)
			"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('86503198-b81b-43fe-81ee-ad45b8848ac9')"
		}
	)
}
Add-MgTeamMember -TeamId $teamId -BodyParameter $params
```
This example shows how to use the Add-MgTeamMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Add-MgTeamMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	Values = @(
		@{
			"@odata.type" = "microsoft.graph.aadUserConversationMember"
			Roles = @(
			)
			"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('18a80140-b0fb-4489-b360-2f6efaf225a0')"
		}
		@{
			"@odata.type" = "microsoft.graph.aadUserConversationMember"
			Roles = @(
				"owner"
			)
			"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('86503198-b81b-43fe-81ee-ad45b8848ac9')"
		}
	)
}
Add-MgTeamMember -TeamId $teamId -BodyParameter $params
```
This example shows how to use the Add-MgTeamMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Add-MgTeamMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	Values = @(
		@{
			"@odata.type" = "microsoft.graph.aadUserConversationMember"
			Roles = @(
			)
			"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('jacob@contoso.com')"
		}
		@{
			"@odata.type" = "microsoft.graph.aadUserConversationMember"
			Roles = @(
				"owner"
			)
			"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('alex@contoso.com')"
		}
	)
}
Add-MgTeamMember -TeamId $teamId -BodyParameter $params
```
This example shows how to use the Add-MgTeamMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
