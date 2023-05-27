### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/users/{id}"
}

New-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorByRef -ConnectedOrganizationId $connectedOrganizationId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaEntitlementManagementConnectedOrganizationInternalSponsorByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

