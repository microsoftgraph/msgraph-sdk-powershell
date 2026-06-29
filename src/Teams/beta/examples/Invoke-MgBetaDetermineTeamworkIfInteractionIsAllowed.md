### Example 1: Determine if the signed-in user can create a chat with another user in the same tenant using their ID

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	users = @(
		@{
			"@odata.type" = "microsoft.graph.teamworkUserIdentity"
			id = "59b5bc69-ca73-4ffd-a2e0-88a79115d13b"
		}
	)
	interactionType = "createChat"
}

Invoke-MgBetaDetermineTeamworkIfInteractionIsAllowed -BodyParameter $params

```
This example will determine if the signed-in user can create a chat with another user in the same tenant using their id

### Example 2: Determine if the signed-in user can create a chat with another user in a different tenant using their ID and tenant ID

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	users = @(
		@{
			"@odata.type" = "microsoft.graph.teamworkUserIdentity"
			id = "59b5bc69-ca73-4ffd-a2e0-88a79115d13b"
			tenantId = "b11186db-6149-4b3d-95ad-23c9e1bf6853"
		}
	)
	interactionType = "createChat"
}

Invoke-MgBetaDetermineTeamworkIfInteractionIsAllowed -BodyParameter $params

```
This example will determine if the signed-in user can create a chat with another user in a different tenant using their id and tenant id

### Example 3: Determine if the signed-in user can create a chat with another user using their user principal name

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	users = @(
		@{
			"@odata.type" = "microsoft.graph.teamworkUserIdentity"
			userPrincipalName = "maia@contoso.com"
		}
	)
	interactionType = "createChat"
}

Invoke-MgBetaDetermineTeamworkIfInteractionIsAllowed -BodyParameter $params

```
This example will determine if the signed-in user can create a chat with another user using their user principal name

### Example 4: Determine if the signed-in user can create a chat with another user using their email

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	users = @(
		@{
			"@odata.type" = "microsoft.graph.emailIdentity"
			email = "LauraW@contoso.com"
		}
	)
	interactionType = "createChat"
}

Invoke-MgBetaDetermineTeamworkIfInteractionIsAllowed -BodyParameter $params

```
This example will determine if the signed-in user can create a chat with another user using their email

### Example 5: Determine if the signed-in user can create a chat with three other users

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	users = @(
		@{
			"@odata.type" = "microsoft.graph.emailIdentity"
			email = "LauraW@foo.com"
		}
		@{
			"@odata.type" = "microsoft.graph.teamworkUserIdentity"
			userPrincipalName = "MaiaR@foobar.com"
		}
		@{
			"@odata.type" = "microsoft.graph.teamworkUserIdentity"
			id = "bd6a223f-59b5-46dd-90bc-0ddebaf3da5a"
		}
	)
	interactionType = "createChat"
}

Invoke-MgBetaDetermineTeamworkIfInteractionIsAllowed -BodyParameter $params

```
This example will determine if the signed-in user can create a chat with three other users

