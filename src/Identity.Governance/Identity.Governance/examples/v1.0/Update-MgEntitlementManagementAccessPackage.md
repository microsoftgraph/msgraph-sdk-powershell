### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "Access Package New Name"
}
Update-MgEntitlementManagementAccessPackage -AccessPackageId $accessPackageId -BodyParameter $params
```
