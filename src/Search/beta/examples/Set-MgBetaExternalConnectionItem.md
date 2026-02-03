### Example: Create a custom item

```powershell

Import-Module Microsoft.Graph.Beta.Search

$params = @{
	acl = @(
		@{
			type = "user"
			value = "e811976d-83df-4cbd-8b9b-5215b18aa874"
			accessType = "grant"
			identitySource = "azureActiveDirectory"
		}
		@{
			type = "group"
			value = "14m1b9c38qe647f6a"
			accessType = "deny"
			identitySource = "external"
		}
	)
	properties = @{
		title = "Error in the payment gateway"
		priority = 
		assignee = "john@contoso.com"
	}
	content = @{
		value = "Error in payment gateway..."
		type = "text"
	}
}

Set-MgBetaExternalConnectionItem -ExternalConnectionId $externalConnectionId -ExternalItemId $externalItemId -BodyParameter $params

```
This example will create a custom item

