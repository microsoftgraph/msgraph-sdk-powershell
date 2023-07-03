### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.Governance

$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/groups/c0a74b4d-2694-4d5d-a964-1bee4ff0aaf2"
}

New-MgEntitlementManagementAccessPackageIncompatibleGroupByRef -AccessPackageId $accessPackageId -BodyParameter $params
```
This example shows how to use the New-MgEntitlementManagementAccessPackageIncompatibleGroupByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

