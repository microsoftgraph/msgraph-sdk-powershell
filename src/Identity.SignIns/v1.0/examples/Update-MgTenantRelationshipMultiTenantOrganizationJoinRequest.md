### Example 1: Join a multitenant organization

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	addedByTenantId = "1fd6544e-e994-4de2-9f1b-787b51c7d325"
}

Update-MgTenantRelationshipMultiTenantOrganizationJoinRequest -BodyParameter $params

```
This example will join a multitenant organization

### Example 2: Reset a failed join request

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	addedByTenantId = "00000000-0000-0000-0000-000000000000"
}

Update-MgTenantRelationshipMultiTenantOrganizationJoinRequest -BodyParameter $params

```
This example will reset a failed join request

