### Example 1: Add members in bulk to a team

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	values = @(
		@{
			"@odata.type" = "microsoft.graph.aadUserConversationMember"
			roles = @(
			)
			"user@odata.bind" = "https://graph.microsoft.com/beta/users('18a80140-b0fb-4489-b360-2f6efaf225a0')"
		}
		@{
			"@odata.type" = "microsoft.graph.aadUserConversationMember"
			roles = @(
			"owner"
		)
		"user@odata.bind" = "https://graph.microsoft.com/beta/users('86503198-b81b-43fe-81ee-ad45b8848ac9')"
	}
)
}

Add-MgBetaTeamMember -TeamId $teamId -BodyParameter $params

```
This example will add members in bulk to a team

### Example 2: Add members in bulk to a team using user principal name

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	values = @(
		@{
			"@odata.type" = "microsoft.graph.aadUserConversationMember"
			roles = @(
			)
			"user@odata.bind" = "https://graph.microsoft.com/beta/users('jacob@contoso.com')"
		}
		@{
			"@odata.type" = "microsoft.graph.aadUserConversationMember"
			roles = @(
			"owner"
		)
		"user@odata.bind" = "https://graph.microsoft.com/beta/users('alex@contoso.com')"
	}
)
}

Add-MgBetaTeamMember -TeamId $teamId -BodyParameter $params

```
This example will add members in bulk to a team using user principal name

