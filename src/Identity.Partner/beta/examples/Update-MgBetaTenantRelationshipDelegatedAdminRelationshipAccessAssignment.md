### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Partner

$params = @{
	accessDetails = @{
		unifiedRoles = @(
			@{
				roleDefinitionId = "88d8e3e3-8f55-4a1e-953a-9b9898b8876b"
			}
			@{
				roleDefinitionId = "44367163-eba1-44c3-98af-f5787879f96a"
			}
			@{
				roleDefinitionId = "729827e3-9c14-49f7-bb1b-9608f156bbb8"
			}
		)
	}
}

Update-MgBetaTenantRelationshipDelegatedAdminRelationshipAccessAssignment -DelegatedAdminRelationshipId $delegatedAdminRelationshipId -DelegatedAdminAccessAssignmentId $delegatedAdminAccessAssignmentId -BodyParameter $params

```
This example shows how to use the Update-MgBetaTenantRelationshipDelegatedAdminRelationshipAccessAssignment Cmdlet.

