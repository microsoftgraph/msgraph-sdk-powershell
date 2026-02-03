### Example 1: Create a one-on-one chat

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
This example will create a one-on-one chat

### Example 2: Create a group chat

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
This example will create a group chat

### Example 3: Create a one-on-one chat with installed apps

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
installedApps = @(
@{
	"teamsApp@odata.bind" = "https://graph.microsoft.com/beta/appCatalogs/teamsApps/05F59CEC-A742-4A50-A62E-202A57E478A4"
}
)
}

New-MgBetaChat -BodyParameter $params

```
This example will create a one-on-one chat with installed apps

### Example 4: Create a one-on-one chat using user principal name

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
This example will create a one-on-one chat using user principal name

### Example 5: Create a group chat with in-tenant guest

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
This example will create a group chat with in-tenant guest

### Example 6: Create a one-on-one chat with a federated user (outside of own organization)

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
	tenantId = "4dc1fe35-8ac6-4f0d-904a-7ebcd364bea1"
}
)
}

New-MgBetaChat -BodyParameter $params

```
This example will create a one-on-one chat with a federated user (outside of own organization)

