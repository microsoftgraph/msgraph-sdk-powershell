### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Partner

$params = @{
	action = "lockForApproval"
}

New-MgBetaTenantRelationshipDelegatedAdminRelationshipRequest -DelegatedAdminRelationshipId $delegatedAdminRelationshipId -BodyParameter $params

```
This example shows how to use the New-MgBetaTenantRelationshipDelegatedAdminRelationshipRequest Cmdlet.

