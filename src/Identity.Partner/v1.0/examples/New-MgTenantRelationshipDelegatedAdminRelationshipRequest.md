### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.Partner

$params = @{
	action = "lockForApproval"
}

New-MgTenantRelationshipDelegatedAdminRelationshipRequest -DelegatedAdminRelationshipId $delegatedAdminRelationshipId -BodyParameter $params

```
This example shows how to use the New-MgTenantRelationshipDelegatedAdminRelationshipRequest Cmdlet.

