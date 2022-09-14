### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/users/{id}"
}
New-MgEntitlementManagementConnectedOrganizationInternalSponsorByRef -ConnectedOrganizationId $connectedOrganizationId -BodyParameter $params
```
