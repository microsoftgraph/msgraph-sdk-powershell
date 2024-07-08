### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/users/{id}"
}

New-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorByRef -ConnectedOrganizationId $connectedOrganizationId -BodyParameter $params

```
This example shows how to use the New-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorByRef Cmdlet.

