###Example 1
```
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/users/{id}"
}
New-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef -ConnectedOrganizationId $connectedOrganizationId -BodyParameter $params
```
