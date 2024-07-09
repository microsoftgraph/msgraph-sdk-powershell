### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Partner

$params = @{
	accessContainer = @{
		accessContainerId = "869713c9-0b28-4d08-8949-ae07ae1bf528"
		accessContainerType = "securityGroup"
	}
	accessDetails = @{
		unifiedRoles = @(
			@{
				roleDefinitionId = "29232cdf-9323-42fd-ade2-1d097af3e4de"
			}
			@{
				roleDefinitionId = "f2ef992c-3afb-46b9-b7cf-a126ee74c451"
			}
			@{
				roleDefinitionId = "729827e3-9c14-49f7-bb1b-9608f156bbb8"
			}
			@{
				roleDefinitionId = "3a2c62db-5318-420d-8d74-23affee5d9d5"
			}
		)
	}
}

New-MgBetaTenantRelationshipDelegatedAdminRelationshipAccessAssignment -DelegatedAdminRelationshipId $delegatedAdminRelationshipId -BodyParameter $params

```
This example shows how to use the New-MgBetaTenantRelationshipDelegatedAdminRelationshipAccessAssignment Cmdlet.

