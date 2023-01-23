### Example 1: Using the New-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/users/{id}"
}
New-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorByRef -ConnectedOrganizationId $connectedOrganizationId -BodyParameter $params
```
This example shows how to use the New-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
