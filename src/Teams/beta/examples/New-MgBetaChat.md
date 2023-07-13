### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	chatType = "oneOnOne"
	members = @(
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			roles = @(
				"owner"
			)
			"user@odata.bind" = "https://graph.microsoft.com/beta/users('8b081ef6-4792-4def-b2c9-c363a1bf41d5')"
		}
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			roles = @(
				"owner"
			)
			"user@odata.bind" = "https://graph.microsoft.com/beta/users('82af01c5-f7cc-4a2e-a728-3a5df21afd9d')"
		}
	)
}

New-MgBetaChat -BodyParameter $params
```
This example shows how to use the New-MgBetaChat Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	chatType = "group"
	topic = "Group chat title"
	members = @(
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			roles = @(
				"owner"
			)
			"user@odata.bind" = "https://graph.microsoft.com/beta/users('8c0a1a67-50ce-4114-bb6c-da9c5dbcf6ca')"
		}
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			roles = @(
				"owner"
			)
			"user@odata.bind" = "https://graph.microsoft.com/beta/users('82fe7758-5bb3-4f0d-a43f-e555fd399c6f')"
		}
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			roles = @(
				"owner"
			)
			"user@odata.bind" = "https://graph.microsoft.com/beta/users('3626a173-f2bc-4883-bcf7-01514c3bfb82')"
		}
	)
}

New-MgBetaChat -BodyParameter $params
```
This example shows how to use the New-MgBetaChat Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	chatType = "oneOnOne"
	members = @(
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			roles = @(
				"owner"
			)
			"user@odata.bind" = "https://graph.microsoft.com/beta/users('jacob@contoso.com')"
		}
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			roles = @(
				"owner"
			)
			"user@odata.bind" = "https://graph.microsoft.com/beta/users('alex@contoso.com')"
		}
	)
}

New-MgBetaChat -BodyParameter $params
```
This example shows how to use the New-MgBetaChat Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	chatType = "group"
	topic = "Group chat title"
	members = @(
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			roles = @(
				"owner"
			)
			"user@odata.bind" = "https://graph.microsoft.com/beta/users('8c0a1a67-50ce-4114-bb6c-da9c5dbcf6ca')"
		}
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			roles = @(
				"owner"
			)
			"user@odata.bind" = "https://graph.microsoft.com/beta/users('82fe7758-5bb3-4f0d-a43f-e555fd399c6f')"
		}
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			roles = @(
				"guest"
			)
			"user@odata.bind" = "https://graph.microsoft.com/beta/users('8ba98gf6-7fc2-4eb2-c7f2-aef9f21fd98g')"
		}
	)
}

New-MgBetaChat -BodyParameter $params
```
This example shows how to use the New-MgBetaChat Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

