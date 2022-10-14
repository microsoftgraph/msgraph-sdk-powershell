### Example 1: Using the New-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/users/{id}"
}
New-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef -ConnectedOrganizationId $connectedOrganizationId -BodyParameter $params
```
This example shows how to use the New-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
