### Example 1: Using the New-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/users/{id}"
}
New-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorByRef -ConnectedOrganizationId $connectedOrganizationId -BodyParameter $params
```
This example shows how to use the New-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
